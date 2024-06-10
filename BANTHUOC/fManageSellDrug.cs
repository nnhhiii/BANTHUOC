/*using BANTHUOC.Models;
using System.Data;

namespace BANTHUOC
{
    public partial class fManageSellDrug : Form
    {
        // Biến toàn cục để lưu trữ hóa đơn nhập hàng hiện tại
        private Invoice currentInvoice = null;
        private EFDbContext db = new EFDbContext();
        public fManageSellDrug()
        {
            InitializeComponent();
        }
        private void fManageSellDrug_Load(object sender, EventArgs e)
        {
            tenThuoc.DisplayMember = "drug_name";
            tenThuoc.ValueMember = "id";
            tenThuoc.DataSource = db.Thuoc
                .Select(c => new { c.id, c.drug_name })
                .ToList();
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
                if (unitOfMeasure != null)
                {
                    // Lấy tên đơn vị đo lường từ bảng DonVi
                    donVi.Text = unitOfMeasure.unit_name;
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy đơn vị đo lường
                    donVi.Text = "Đơn vị không xác định";
                }
            }

            soLuong.Focus();
        }
        private void LoadInvoiceDetail_In_Datagridview()
        {
            // Load the invoice details into the DataGridView
            var invoiceDetails = db.CTHDBanHang
                .Where(c => c.invoice_id == currentInvoice.id)
                .Join(db.Thuoc, cthd => cthd.drug_id, drug => drug.id, (cthd, drug) => new { cthd, drug })
                .Join(db.NhaCungCap, cthdSupplier => cthdSupplier.drug.supplier_id, supplier => supplier.id, (cthdSupplier, supplier) => new { cthdSupplier, supplier })
                .Join(db.DonViTinh, cthdUnit => cthdUnit.cthdSupplier.drug.unit_of_measure_id, unit => unit.id, (cthdUnit, unit) => new
                {
                    MaCTHDBanHang = cthdUnit.cthdSupplier.cthd.id,
                    MaThuoc = cthdUnit.cthdSupplier.drug.id,
                    DrugName = cthdUnit.cthdSupplier.drug.drug_name,
                    SupplierName = cthdUnit.supplier.supplier_name,
                    Content = cthdUnit.cthdSupplier.drug.content,
                    Price = cthdUnit.cthdSupplier.drug.price,
                    Quantity = cthdUnit.cthdSupplier.cthd.quantity,
                    UnitName = unit.unit_name,
                    Amount = cthdUnit.cthdSupplier.cthd.amount
                })
                .ToList();

            dataGridView1.DataSource = invoiceDetails;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tenThuoc.Text))
            {
                toolTip1.Show("Hãy chọn thuốc?", tenThuoc, 0, 0, 1000);
                tenThuoc.Focus();
                return;
            }
            if (!int.TryParse(soLuong.Text, out int soluong) || soluong < 1)
            {
                toolTip1.Show("Số lượng không hợp lệ hoặc nhỏ hơn 1", soLuong, 0, 0, 1000);
                soLuong.Focus();
                return;
            }
                
            // Kiểm tra nếu SelectedValue là null hoặc không phải kiểu long
            if (tenThuoc.SelectedValue == null || !(tenThuoc.SelectedValue is long))
            {
                // Hiển thị thông báo lỗi hoặc thực hiện các hành động phù hợp
                MessageBox.Show("Vui lòng chọn một thuốc hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long selectedDrugId = Convert.ToInt64(tenThuoc.SelectedValue);

            // Get the drug price
            decimal donGiaValue = db.Thuoc
                    .Where(p => p.id == selectedDrugId)
                    .Select(p => p.price)
                    .SingleOrDefault();

            // Check if there is a current invoice
            if (currentInvoice == null)
            {
                // Create a new invoice
                currentInvoice = new Invoice
                {
                    total_amount = 0, // Temporarily set total amount to 0
                    creat_at = DateTime.Now,
                    employee_id = 1 // Set the employee_id as needed
                };
                db.HoaDonBanHang.Add(currentInvoice);
                db.SaveChanges();
            }

            // Create a new invoice detail
            InvoiceDetail invoiceDetail = new InvoiceDetail
            {
                invoice_id = currentInvoice.id,
                drug_id = selectedDrugId,
                quantity = soluong,
                amount = soluong * donGiaValue
            };

            db.CTHDBanHang.Add(invoiceDetail);
            db.SaveChanges();

            // Update the drug quantity in the Thuoc table
            Drug drug = db.Thuoc.SingleOrDefault(t => t.id == selectedDrugId);
            if (drug != null)
            {
                drug.quantity -= soluong;
            }

            // Update the total amount in the invoice
            currentInvoice = db.HoaDonBanHang.SingleOrDefault(h => h.id == currentInvoice.id);
            if (currentInvoice != null)
            {
                currentInvoice.total_amount = db.CTHDBanHang
                    .Where(c => c.invoice_id == currentInvoice.id)
                    .Sum(c => c.amount);
                db.SaveChanges();

                // Clear the input fields
                tenThuoc.Text = null;
                donGia.Text = null;
                soLuong.Text = null;
                donVi.Text = null;
                soLuongTon.Text = null;

                LoadInvoiceDetail_In_Datagridview();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    long invoiceDetailID = Convert.ToInt64(dataGridView1.Rows[i].Cells["id"].Value);
                    InvoiceDetail importDetail = db.CTHDBanHang.Single(id => id.id == invoiceDetailID);
                    importDetail.quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["quantity"].Value);

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
                    return;
                }
                // Cập nhật total_amount của ImportInvoice hiện tại
                if (currentInvoice != null)
                {
                    currentInvoice = db.HoaDonBanHang.SingleOrDefault(h => h.id == currentInvoice.id);
                    if (currentInvoice != null)
                    {
                        currentInvoice.total_amount = db.CTHDBanHang
                            .Where(c => c.invoice_id == currentInvoice.id)
                            .Sum(c => c.amount);
                        db.SaveChanges();

                        tenThuoc.Text = null;
                        donGia.Text = null;
                        soLuong.Text = null;
                        donVi.Text = null;
                        soLuongTon.Text = null;

                        LoadInvoiceDetail_In_Datagridview();
                    }
                }
            }
            toolTip1.Show("Lưu thành công.", btnSave, 0, 0, 1000);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                // Lấy giá trị của cell trong cột "id" tại hàng được chọn
                long invoiceDetailID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                // Tìm chi tiết hóa đơn bán hàng trong cơ sở dữ liệu
                InvoiceDetail invoiceDetail = db.CTHDBanHang.SingleOrDefault(id => id.id == invoiceDetailID);
                if (MessageBox.Show("Bạn muốn xóa " + invoiceDetailID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Xóa chi tiết hóa đơn bán hàng khỏi cơ sở dữ liệu
                        db.CTHDBanHang.Remove(invoiceDetail);
                        db.SaveChanges();

                        // Cập nhật lại total_amount của hóa đơn nhập hàng
                        if (currentInvoice != null)
                        {
                            currentInvoice.total_amount = db.CTHDBanHang
                                .Where(c => c.invoice_id == currentInvoice.id)
                                .Sum(c => c.amount);
                            db.SaveChanges();

                            // Hiển thị lại danh sách chi tiết hóa đơn nhập hàng
                            LoadInvoiceDetail_In_Datagridview();
                        }
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

*/

using BANTHUOC.Models;
using System.Data;
using System.ComponentModel;

namespace BANTHUOC
{
    public partial class fManageSellDrug : Form
    {
        private Staff loggedInEmployee;
        // Biến toàn cục để lưu trữ hóa đơn nhập hàng hiện tại
        private Invoice currentInvoice = null;
        private EFDbContext db = new EFDbContext();
        private BindingList<InvoiceDetailDisplay> displayDetails = new BindingList<InvoiceDetailDisplay>();
        private List<InvoiceDetail> tempInvoiceDetails = new List<InvoiceDetail>(); // Danh sách tạm thời

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

            dataGridView1.AutoGenerateColumns = false;
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
            if (string.IsNullOrWhiteSpace(tenThuoc.Text))
            {
                toolTip1.Show("Hãy chọn thuốc?", tenThuoc, 0, 0, 1000);
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

            // Kiểm tra nếu SelectedValue là null hoặc không phải kiểu long
            if (tenThuoc.SelectedValue == null || !(tenThuoc.SelectedValue is long))
            {
                // Hiển thị thông báo lỗi hoặc thực hiện các hành động phù hợp
                MessageBox.Show("Vui lòng chọn một thuốc hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the drug price
            decimal donGiaValue = db.Thuoc
                    .Where(p => p.id == selectedDrugId)
                    .Select(p => p.price)
                    .SingleOrDefault();

            // Create a new invoice detail and add it to the temporary list
            InvoiceDetail invoiceDetail = new InvoiceDetail
            {
                drug_id = selectedDrugId,
                quantity = soluong,
                amount = soluong * donGiaValue
            };

            tempInvoiceDetails.Add(invoiceDetail);

            // Add new item to the BindingList
            drug = db.Thuoc.FirstOrDefault(t => t.id == invoiceDetail.drug_id);
            var supplier = drug != null ? db.NhaCungCap.FirstOrDefault(s => s.id == drug.supplier_id) : null;
            var unit = drug != null ? db.DonViTinh.FirstOrDefault(u => u.id == drug.unit_of_measure_id) : null;

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
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            // Kiểm tra nếu chưa có hóa đơn hiện tại thì tạo mới
            if (currentInvoice == null)
            {
                currentInvoice = new Invoice
                {
                    total_amount = 0, // Tạm thời đặt tổng tiền bằng 0
                    create_at = DateTime.Now,
                    employee_id = loggedInEmployee.id // Sử dụng employee_id của nhân viên đăng nhập
                };
                db.HoaDonBanHang.Add(currentInvoice);
                db.SaveChanges();
            }

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
                var invoiceDetail = tempInvoiceDetails.FirstOrDefault(detail => detail.drug_id == Convert.ToInt64(dataGridView1.Rows[rowIndex].Cells["drug_id"].Value));
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
