using BANTHUOC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fNewDrug : Form
    {
        private Staff loggedInEmployee;
        public fNewDrug(Staff loggedInEmployee)
        {
            InitializeComponent();
            this.loggedInEmployee = loggedInEmployee;
        }

        private void fNewDrug_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                loaiThuoc.DisplayMember = "category_name";
                loaiThuoc.ValueMember = "category_id";
                loaiThuoc.DataSource = db.LoaiDuocPham
                   .Select(c => new { c.category_id, c.category_name })
                   .ToList();

                nhaCungCap.DisplayMember = "supplier_name";
                nhaCungCap.ValueMember = "id";
                nhaCungCap.DataSource = db.NhaCungCap
                   .Select(c => new { c.id, c.supplier_name })
                   .ToList();

                donViBan.DisplayMember = "unit_name";
                donViBan.ValueMember = "id";
                donViBan.DataSource = db.DonViTinh
                   .Select(c => new { c.id, c.unit_name })
                   .ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra các giá trị nhập vào
            if (string.IsNullOrWhiteSpace(tenThuoc.Text))
            {
                toolTip1.Show("Hãy nhập tên thuốc?", tenThuoc, 0, 0, 1000);
                tenThuoc.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(hamLuong.Text))
            {
                toolTip1.Show("Hãy nhập hàm lượng?", hamLuong, 0, 0, 1000);
                hamLuong.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(dongGoi.Text))
            {
                toolTip1.Show("Hãy nhập quy cách đóng gói?", dongGoi, 0, 0, 1000);
                dongGoi.Focus();
                return;
            }
            if (!decimal.TryParse(giaNhap.Text, out decimal giaNhapValue) || giaNhapValue < 0)
            {
                toolTip1.Show("Giá nhập không hợp lệ hoặc nhỏ hơn 0", giaNhap, 0, 0, 1000);
                giaNhap.Focus();
                return;
            }
            if (!decimal.TryParse(giaBan.Text, out decimal giaBanValue) || giaBanValue < 0)
            {
                toolTip1.Show("Giá bán không hợp lệ hoặc nhỏ hơn 0", giaBan, 0, 0, 1000);
                giaBan.Focus();
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

            try
            {
                using (var db = new EFDbContext())
                {
                    // Tạo một thể hiện mới của thuốc
                    Drug drug = new Drug
                    {
                        drug_name = tenThuoc.Text,
                        content = hamLuong.Text,
                        packing = dongGoi.Text,
                        price = giaBanValue,
                        usage_instructions = huongDanSuDung.Text,
                        side_effects = tacDungPhu.Text,
                        description = moTa.Text,
                        quantity = soluong,
                        contraindications = chongChiDinh.Text,
                        category_id = Convert.ToInt64(loaiThuoc.SelectedValue),
                        supplier_id = Convert.ToInt64(nhaCungCap.SelectedValue),
                        unit_of_measure_id = Convert.ToInt64(donViBan.SelectedValue),
                        expiry_date = expiryDate
                    };

                    db.Thuoc.Add(drug);
                    db.SaveChanges(); // Save drug first to get the drug_id
                                      // Lưu hình ảnh nếu có
                    if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                    {
                        string ext = txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."),
                            txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                        drug.image = drug.id + ext;
                        pictureBox1.Image.Save(Utility.ImagePath + drug.id + ext);
                        db.SaveChanges(); //Lưu các thay đổi vào csdl
                    }

                    decimal totalAmount = soluong * giaNhapValue;
                    ImportInvoice importInvoice = new ImportInvoice
                    {
                        total_amount = totalAmount, 
                        create_at = DateTime.Now,
                        employee_id = loggedInEmployee.id
                    };

                    db.HoaDonNhapHang.Add(importInvoice);
                    db.SaveChanges(); // Save invoice first to get the invoice_id

                    // Tạo một chi tiết hóa đơn nhập hàng mới
                    ImportDetail importDetail = new ImportDetail
                    {
                        import_invoice_id = importInvoice.id,
                        drug_id = drug.id,
                        quantity = soluong,
                        import_price = giaNhapValue,
                        amount = totalAmount,
                        expiry_date = drug.expiry_date
                    };
                    db.CTHDNhapHang.Add(importDetail);
                    db.SaveChanges();


                    // Xóa trống và thiết lập lại các điều khiển
                    tenThuoc.Text = null;
                    hamLuong.Text = null;
                    dongGoi.Text = null;
                    huongDanSuDung.Text = null;
                    tacDungPhu.Text = null;
                    chongChiDinh.Text = null;
                    moTa.Text = null;
                    hanSuDung.Text = null;
                    txtImageFile.Text = null;

                    // Hiển thị thông báo thành công
                    toolTip1.Show("Lưu thành công!", btnSave, 0, 0, 1000);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
            }
            tenThuoc.Focus();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All file|*.*|Bitmap File | *.bmp; *.dib | JPEG | *.jpg; *.jpe; *.jpeg; *.jfif | GIF | *.gif | TIFF | *.tif; *.tiff | PNG | *.png | ICO | *.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void giaNhap_ValueChanged(object sender, EventArgs e)
        {
            if (giaNhap.Value < 0)
            {
                MessageBox.Show("Giá trị không được nhỏ hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                giaNhap.Value = 0;
            }
        }

        private void giaBan_ValueChanged(object sender, EventArgs e)
        {
            if (giaBan.Value < 0)
            {
                MessageBox.Show("Giá trị không được nhỏ hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                giaBan.Value = 0;
            }
        }

        private void soLuongTheoDonViBan_ValueChanged(object sender, EventArgs e)
        {
            if (soLuongTheoDonViBan.Value < 1)
            {
                MessageBox.Show("Giá trị không được nhỏ hơn 1", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                soLuongTheoDonViBan.Value = 1;  // Đặt lại giá trị về 1 nếu nhỏ hơn 1
            }
        }
    }
}
