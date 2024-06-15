using BANTHUOC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fImportGood : Form
    {
        // Biến toàn cục để lưu trữ hóa đơn nhập hàng hiện tại
        private ImportInvoice currentImportInvoice = null;
        private EFDbContext db = new EFDbContext();
        private Staff loggedInEmployee;

        public fImportGood(Staff loggedInEmployee)
        {
            InitializeComponent();
            this.loggedInEmployee = loggedInEmployee;
        }
  
        private void fImportGood_Load(object sender, EventArgs e)
        {
            tenThuoc.DisplayMember = "drug_name";
            tenThuoc.ValueMember = "id";
            tenThuoc.DataSource = db.Thuoc
                .Select(c => new { c.id, c.drug_name })
                .ToList();
        }

        private void Update_TotalAmount()
        {
            if (currentImportInvoice != null)
            {
                currentImportInvoice = db.HoaDonNhapHang.FirstOrDefault(h => h.id == currentImportInvoice.id);
                if (currentImportInvoice != null)
                {
                    currentImportInvoice.total_amount = db.CTHDNhapHang
                        .Where(c => c.import_invoice_id == currentImportInvoice.id)
                        .Sum(c => c.amount);
                    db.SaveChanges();

                    tenThuoc.Text = null;
                    giaNhap.Text = null;
                    soLuongTheoDonViBan.Text = null;

                    dataGridView1.DataSource = db.CTHDNhapHang
                        .Where(c => c.import_invoice_id == currentImportInvoice.id)
                        .ToList();
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    long importDetailID = Convert.ToInt64(dataGridView1.Rows[i].Cells["id"].Value);
                    ImportDetail importDetail = db.CTHDNhapHang.Single(id => id.id == importDetailID);

                    importDetail.quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["quantity"].Value);
                    importDetail.import_price = Convert.ToDecimal(dataGridView1.Rows[i].Cells["import_price"].Value);
                    importDetail.amount = importDetail.quantity * importDetail.import_price;
                    importDetail.expiry_date = Convert.ToDateTime(dataGridView1.Rows[i].Cells["expiry_date"].Value);

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
                    return;
                }
                // Cập nhật total_amount của ImportInvoice hiện tại
                Update_TotalAmount();


            }
            toolTip1.Show("Lưu thành công.", btnSave, 0, 0, 1000);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tenThuoc.SelectedIndex == -1)
            {
                toolTip1.Show("Hãy chọn thuốc", tenThuoc, 0, 0, 1000);
                tenThuoc.Focus();
                return;
            }
            if (!decimal.TryParse(giaNhap.Text, out decimal giaNhapValue) || giaNhapValue < 0)
            {
                toolTip1.Show("Giá nhập không hợp lệ hoặc nhỏ hơn 0", giaNhap, 0, 0, 1000);
                giaNhap.Focus();
                return;
            }
            if (!int.TryParse(soLuongTheoDonViBan.Text, out int soluong) || soluong < 1)
            {
                toolTip1.Show("Số lượng không hợp lệ hoặc nhỏ hơn 1", soLuongTheoDonViBan, 0, 0, 1000);
                soLuongTheoDonViBan.Focus();
                return;
            }
            DateTime expiryDate = hanSuDung.Value.Date;
            DateTime minExpiryDate = DateTime.Now.Date.AddMonths(6);

            if (expiryDate <= DateTime.Now.Date || expiryDate < minExpiryDate)
            {
                toolTip1.Show("Hạn sử dụng phải ít nhất 6 tháng sau ngày hiện tại và không phải là hôm nay hoặc nhỏ hơn", hanSuDung, 0, 0, 3000);
                hanSuDung.Focus();
                return;
            }
            using (var db = new EFDbContext())
            {
                // Kiểm tra xem có hóa đơn nhập hàng hiện tại không
                if (currentImportInvoice == null)
                {
                    // Tạo một hóa đơn nhập hàng mới
                    currentImportInvoice = new ImportInvoice
                    {
                        total_amount = 0, // Tạm thời gán tổng tiền là 0
                        create_at = DateTime.Now,
                        employee_id = loggedInEmployee.id
                    };
                    db.HoaDonNhapHang.Add(currentImportInvoice);
                    db.SaveChanges();
                }

                // Tạo một chi tiết hóa đơn nhập hàng mới
                ImportDetail importDetail = new ImportDetail
                {
                    import_invoice_id = currentImportInvoice.id,
                    drug_id = Convert.ToInt64(tenThuoc.SelectedValue),
                    quantity = soluong,
                    import_price = giaNhapValue,
                    amount = soluong * giaNhapValue,
                    expiry_date = expiryDate
                };

                db.CTHDNhapHang.Add(importDetail);
                db.SaveChanges();

                Drug drug = db.Thuoc.FirstOrDefault(t => t.id == Convert.ToInt64(tenThuoc.SelectedValue));

                // Tăng quantity trong bảng Thuoc
                if (drug != null)
                {
                    drug.quantity += soluong;
                }

                //Cập nhật lại total_amount của hóa đơn nhập hàng
                currentImportInvoice = db.HoaDonNhapHang.FirstOrDefault(h => h.id == currentImportInvoice.id);
                Update_TotalAmount();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Lấy giá trị của cell trong cột "id" tại hàng được chọn
                long importDetailID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                // Tìm chi tiết hóa đơn nhập hàng trong cơ sở dữ liệu
                ImportDetail importDetail = db.CTHDNhapHang.SingleOrDefault(id => id.id == importDetailID);
                if (MessageBox.Show("Bạn muốn xóa " + importDetailID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Xóa chi tiết hóa đơn nhập hàng khỏi cơ sở dữ liệu
                        db.CTHDNhapHang.Remove(importDetail);
                        db.SaveChanges();

                        // Cập nhật lại total_amount của hóa đơn nhập hàng
                        Update_TotalAmount();
                    }
                    catch (Exception ex)
                    {
                        toolTip1.Show("Xóa thất bại? Error: " + ex.Message, dataGridView1, 0, 0, 1000);
                    }
                }
            }
        }
    }
}
