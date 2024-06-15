using BANTHUOC.Models;
using System.Data;
using System.ComponentModel;

namespace BANTHUOC
{
    public partial class fManageSellDrug : Form
    {
        private Staff loggedInEmployee;
        private EFDbContext db = new EFDbContext();

        // Biến toàn cục để lưu trữ hóa đơn bán hàng hiện tại
        private Invoice currentInvoice = null; 

        // Danh sách chi tiết hóa đơn để hiển thị trong DataGridView
        private BindingList<InvoiceDetailDisplay> displayDetails = new BindingList<InvoiceDetailDisplay>();

        // Danh sách tạm thời các chi tiết hóa đơn
        private List<InvoiceDetail> tempInvoiceDetails = new List<InvoiceDetail>(); 

        public fManageSellDrug(Staff loggedInEmployee)
        {
            InitializeComponent();
            this.loggedInEmployee = loggedInEmployee; 
        }

        private void fManageSellDrug_Load(object sender, EventArgs e)
        {
            tenThuoc.DisplayMember = "drug_name";
            tenThuoc.ValueMember = "id";
            tenThuoc.DataSource = db.Thuoc
                .Select(c => new { c.id, c.drug_name })
                .ToList();

            // Ngăn DataGridView tự động tạo các cột dựa trên nguồn dữ liệu
            dataGridView1.AutoGenerateColumns = false;
            // Thiết lập nguồn dữ liệu cho DataGridView là danh sách chi tiết hóa đơn
            dataGridView1.DataSource = displayDetails; 

        }

        private void tenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            long DrugID = Convert.ToInt64(tenThuoc.SelectedValue);

            // Lấy đơn giá của thuốc
            donGia.Text = db.Thuoc
                .Where(p => p.id == DrugID)
                .Select(p => p.price)
                .SingleOrDefault()
                .ToString();

            // Lấy số lượng tồn của thuốc
            var drugQuantity = db.Thuoc
                .Where(p => p.id == DrugID)
                .Select(p => p.quantity)
                .SingleOrDefault();

            // Kiểm tra nếu có giá trị số lượng tồn
            if (drugQuantity != 0)
            {
                soLuongTon.Text = drugQuantity.ToString();
            }
            else
            {
                soLuongTon.Text = "Số lượng tồn đang bằng 0, Hãy nhập thêm!";
            }

            // Lấy unit_of_measure_id từ bảng Thuoc
            var selectedDrug = db.Thuoc.SingleOrDefault(p => p.id == DrugID);
            if (selectedDrug != null)
            {
                long unitOfMeasureId = selectedDrug.unit_of_measure_id;

                // Kiểm tra xem unitOfMeasureId có tồn tại trong bảng DonViTinh không
                var unitOfMeasure = db.DonViTinh.SingleOrDefault(u => u.id == unitOfMeasureId);
                
                // Lấy tên đơn vị đo lường từ bảng DonVi
                donVi.Text = unitOfMeasure.unit_name;
               
            }

            soLuong.Focus();
        }
        private void UpdateTotalAmount()
        {
            // Tính tổng số tiền từ danh sách tempInvoiceDetails
            decimal totalAmount = tempInvoiceDetails.Sum(detail => detail.amount);
            // Định dạng số tiền với 2 chữ số thập phân
            tongThanhTien.Text = totalAmount.ToString("N2"); 
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tenThuoc.SelectedIndex == -1 || tenThuoc.SelectedValue == null || !(tenThuoc.SelectedValue is long))
            {
                toolTip1.Show("Vui lòng chọn một thuốc hợp lệ!", tenThuoc, 0, 0, 1000);
                tenThuoc.Focus();
                return;
            }
            if (!int.TryParse(soLuong.Text, out int soluong) || soluong < 1)
            {
                toolTip1.Show("Số lượng không hợp lệ hoặc nhỏ hơn 1", soLuong, 0, 0, 1000);
                soLuong.Focus();
                return;
            }
            
            long selectedDrugId = Convert.ToInt64(tenThuoc.SelectedValue);
            // Kiểm tra xem sản phẩm đã tồn tại trong danh sách tạm thời hay không
            foreach (var detail in tempInvoiceDetails)
            {
                if (detail.drug_id == selectedDrugId)
                {
                    MessageBox.Show("Sản phẩm này đã được chọn trước đó!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tenThuoc.Text = null;
                    donGia.Text = null;
                    soLuong.Text = null;
                    soLuongTon.Text = null;
                    donVi.Text = null;
                    return;
                }
            }
            // Kiểm tra số lượng tồn
            var drug = db.Thuoc.FirstOrDefault(t => t.id == selectedDrugId);
            if (drug != null && soluong > drug.quantity)
            {
                MessageBox.Show("Số lượng nhập vào lớn hơn số lượng tồn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Lấy giá thuốc
            decimal donGiaValue = db.Thuoc
                    .Where(p => p.id == selectedDrugId)
                    .Select(p => p.price)
                    .SingleOrDefault();

            // Tạo chi tiết hóa đơn mới và thêm vào danh sách tạm thời
            InvoiceDetail invoiceDetail = new InvoiceDetail
            {
                drug_id = selectedDrugId,
                quantity = soluong,
                amount = soluong * donGiaValue
            };
            tempInvoiceDetails.Add(invoiceDetail);

            // Thêm chi tiết hiển thị vào BindingList và cập nhật giao diện người dùng
            drug = db.Thuoc.FirstOrDefault(t => t.id == invoiceDetail.drug_id);
            var supplier = db.NhaCungCap.FirstOrDefault(s => s.id == drug.supplier_id);
            var unit = db.DonViTinh.FirstOrDefault(u => u.id == drug.unit_of_measure_id);

            var displayDetail = new InvoiceDetailDisplay
            {
                MaThuoc = invoiceDetail.drug_id,
                DrugName = drug?.drug_name ?? "N/A",
                SupplierName = supplier?.supplier_name ?? "N/A",
                Content = drug?.content ?? "N/A",
                Price = drug?.price ?? 0,
                Quantity = invoiceDetail.quantity,
                UnitName = unit?.unit_name ?? "N/A",
                Amount = invoiceDetail.amount
            };

            displayDetails.Add(displayDetail);
            UpdateTotalAmount();

            tenThuoc.Text = null;
            donGia.Text = null;
            soLuong.Text = null;
            soLuongTon.Text = null;
            donVi.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn Yes, thực hiện xóa
                if (result == DialogResult.Yes)
                {
                    // Xóa mục khỏi danh sách tạm thời và BindingList
                    tempInvoiceDetails.RemoveAt(e.RowIndex);
                    displayDetails.RemoveAt(e.RowIndex);
                    UpdateTotalAmount();
                }
            }
        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Tạo hóa đơn mới
            currentInvoice = new Invoice
            {
                total_amount = 0, // Tạm thời đặt tổng tiền bằng 0
                create_at = DateTime.Now,
                employee_id = loggedInEmployee.id // Sử dụng id của nhân viên đăng nhập
            };
            db.HoaDonBanHang.Add(currentInvoice);
            db.SaveChanges();
            
            // Lưu các chi tiết hóa đơn từ danh sách tạm vào cơ sở dữ liệu
            foreach (var tempDetail in tempInvoiceDetails)
            {
                // Gán invoice_id cho từng chi tiết hóa đơn
                tempDetail.invoice_id = currentInvoice.id;

                // Thêm chi tiết hóa đơn vào cơ sở dữ liệu
                db.CTHDBanHang.Add(tempDetail);

                // Cập nhật số lượng tồn trong bảng Thuoc
                var drug = db.Thuoc.SingleOrDefault(t => t.id == tempDetail.drug_id);
                if (drug != null)
                {
                    drug.quantity -= tempDetail.quantity;
                }
            }

            // Cập nhật tổng tiền của hóa đơn
            currentInvoice.total_amount = tempInvoiceDetails.Sum(detail => detail.amount);
            db.SaveChanges();

            // Xóa danh sách tạm
            tempInvoiceDetails.Clear();
            displayDetails.Clear();

            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Cho phép chỉnh sửa trên cột số lượng, vô hiệu hóa các cột khác
            if (dataGridView1.Columns[e.ColumnIndex].Name != "quantity")
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột nào đã kết thúc chỉnh sửa
            if (dataGridView1.Columns[e.ColumnIndex].Name == "quantity")
            {
                // Lấy chỉ số hàng hiện tại
                int rowIndex = e.RowIndex;

                // Lấy số lượng từ DataGridView
                int newQuantity;
                if (!int.TryParse(dataGridView1.Rows[rowIndex].Cells["quantity"].Value.ToString(), out newQuantity))
                {
                    MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy giá của thuốc từ DataGridView
                decimal price = Convert.ToDecimal(dataGridView1.Rows[rowIndex].Cells["price"].Value);

                // Tính toán lại amount
                decimal amount = newQuantity * price;

                // Cập nhật amount trong DataGridView
                dataGridView1.Rows[rowIndex].Cells["amount"].Value = amount;

                // Tìm và cập nhật chi tiết hóa đơn trong tempInvoiceDetails
                var invoiceDetail = tempInvoiceDetails.FirstOrDefault(detail => detail.drug_id ==
                Convert.ToInt64(dataGridView1.Rows[rowIndex].Cells["drug_id"].Value));
                if (invoiceDetail != null)
                {
                    invoiceDetail.quantity = newQuantity;
                    invoiceDetail.amount = amount;
                }

                // Cập nhật lại tổng số tiền
                UpdateTotalAmount();
            }
        }

    }
}
