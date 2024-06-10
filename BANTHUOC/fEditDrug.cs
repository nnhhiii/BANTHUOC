using BANTHUOC.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fEditDrug : Form
    {
        private Drug drug;
        private long id;
        private EFDbContext db = new EFDbContext();
        public fEditDrug(long id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void fEditDrug_Load(object sender, EventArgs e)
        {
            drug = db.Thuoc
                .Include(d => d.DrugCategory)
                .Include(p => p.Supplier)
                .Include(d => d.Unit)
                .Single(d => d.id == id);

            if (drug == null)
            {
                MessageBox.Show("Không tìm thấy thông tin thuốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            Text = "SỬA ĐỔI THUỐC " + drug.id.ToString();
            tenThuoc.Text = drug.drug_name;
            hamLuong.Text = drug.content;
            dongGoi.Text = drug.packing;
            giaBan.Text = drug.price.ToString();
            soLuongTheoDonViBan.Text = drug.quantity.ToString();
            huongDanSuDung.Text = drug.usage_instructions;
            tacDungPhu.Text = drug.side_effects;
            chongChiDinh.Text = drug.contraindications;
            moTa.Text = drug.description;
            hanSuDung.Text = drug.expiry_date.ToShortDateString();
            txtImageFile.Text = string.IsNullOrWhiteSpace(drug.image) ? null : Utility.ImagePath + drug.image;
            pictureBox1.ImageLocation = txtImageFile.Text; //Hiển thị hình

            var importPrice = db.CTHDNhapHang.FirstOrDefault(c => c.drug_id == drug.id)?.import_price;
            if (importPrice != null)
            {
                giaNhap.Text = importPrice.Value.ToString();
            }

            //hiện combobox loại thuốc
            loaiThuoc.DisplayMember = "category_name";
            loaiThuoc.ValueMember = "category_id";
            loaiThuoc.DataSource = db.LoaiDuocPham.Select(c => new
            {
                c.category_id,
                c.category_name
            }).ToList();
            loaiThuoc.Text = drug.DrugCategory.category_name;


            // nhà cung cap
            nhaCungCap.DisplayMember = "supplier_name";
            nhaCungCap.ValueMember = "id";
            nhaCungCap.DataSource = db.NhaCungCap.Select(c => new
            {
                c.id,
                c.supplier_name
            }).ToList();
            nhaCungCap.Text = drug.Supplier.supplier_name;


            // đơn vị tính
            donViBan.DisplayMember = "unit_name";
            donViBan.ValueMember = "id";
            donViBan.DataSource = db.DonViTinh.Select(c => new
            {
                c.id,
                c.unit_name
            }).ToList();
            donViBan.Text = drug.Unit.unit_name;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
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
            if (decimal.TryParse(giaBan.Text, out decimal giaBanValue))
            {
                if (giaBanValue < 0)
                {
                    toolTip1.Show("Giá trị không được nhỏ hơn 0", giaBan, 0, 0, 1000);
                    giaBan.Focus();
                    return;
                }
            }
            if (int.TryParse(soLuongTheoDonViBan.Text, out int soluong))
            {
                if (soluong < 1)
                {
                    toolTip1.Show("Giá trị không được nhỏ hơn 1", soLuongTheoDonViBan, 0, 0, 1000);
                    soLuongTheoDonViBan.Focus();
                    return;
                }
            }
            DateTime expiryDate = hanSuDung.Value.Date;
            DateTime minExpiryDate = DateTime.Now.Date.AddMonths(6);

            if (expiryDate <= DateTime.Now.Date || expiryDate < minExpiryDate)
            {
                toolTip1.Show("Hạn sử dụng phải ít nhất 6 tháng", hanSuDung, 0, 0, 3000);
                hanSuDung.Focus();
                return;
            }
            try
            {
                drug.drug_name = tenThuoc.Text;
                drug.content = hamLuong.Text;
                drug.packing = dongGoi.Text;
                drug.price = decimal.Parse(giaBan.Text);
                drug.quantity = int.Parse(soLuongTheoDonViBan.Text);
                drug.usage_instructions = huongDanSuDung.Text;
                drug.side_effects = tacDungPhu.Text;
                drug.contraindications = chongChiDinh.Text;
                drug.description = moTa.Text;
                drug.image = Path.GetFileName(txtImageFile.Text);
                drug.expiry_date = expiryDate;

                // Lấy giá trị từ combobox
                drug.category_id = Convert.ToInt64(loaiThuoc.SelectedValue);
                drug.supplier_id = Convert.ToInt64(loaiThuoc.SelectedValue);
                drug.unit_of_measure_id = Convert.ToInt64(loaiThuoc.SelectedValue);

                if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                {
                    string ext = txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."), txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                    drug.image = drug.id + ext;
                    pictureBox1.Image.Save(Utility.ImagePath + drug.id + ext);
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btnSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
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

        /*private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Tìm thuốc với ID tương ứng
                Drug drug = db.Thuoc.SingleOrDefault(c => c.id == id);

                // Kiểm tra nếu thuốc không tồn tại
                if (drug == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin thuốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xác nhận xóa
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin thuốc này?",
                                                    "Xác nhận xóa",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Xóa thông tin thuốc khỏi cơ sở dữ liệu
                    db.Thuoc.Remove(drug);
                    db.SaveChanges();

                    // Thông báo và đóng form
                    MessageBox.Show("Đã xóa thông tin thuốc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DrugDeleted?.Invoke();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, chưa xóa được. Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/
    }
}
