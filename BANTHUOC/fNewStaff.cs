using BANTHUOC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fNewStaff : Form
    {
        private EFDbContext db = new EFDbContext();
        public fNewStaff()
        {
            InitializeComponent();
        }

        private void fNewStaff_Load(object sender, EventArgs e)
        {
            chucvu.DisplayMember = "role_name";
            chucvu.ValueMember = "id";
            chucvu.DataSource = db.VaiTro
                .Select(c => new { c.id, c.role_name })
                .ToList();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hoten.Text))
            {
                toolTip1.Show("Hãy nhập họ và tên", hoten, 0, 0, 3000);
                hoten.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(email.Text))
            {
                toolTip1.Show("Hãy nhập email", email, 0, 0, 3000);
                email.Focus();
                return;
            }
            else if (!IsValidEmail(email.Text))
            {
                toolTip1.Show("Email không hợp lệ", email, 0, 0, 3000);
                email.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(sdt.Text))
            {
                toolTip1.Show("Hãy nhập số điện thoại", sdt, 0, 0, 3000);
                sdt.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(diachi.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ", diachi, 0, 0, 3000);
                diachi.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(gioiTinh.Text))
            {
                toolTip1.Show("Hãy nhập giới tính", gioiTinh, 0, 0, 3000);
                gioiTinh.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(password.Text))
            {
                toolTip1.Show("Hãy nhập mật khẩu", password, 0, 0, 3000);
                password.Focus();
                return;
            }

            DateTime birthday = ngaysinh.Value.Date;
            DateTime minBirthday = DateTime.Now.Date.AddYears(-18);

            if (birthday > DateTime.Now.Date || birthday > minBirthday)
            {
                toolTip1.Show("Chưa đủ 18 tuổi để đi làm", ngaysinh, 0, 0, 3000);
                ngaysinh.Focus();
                return;
            }

            try
            {
                // Kiểm tra email trùng lặp
                if (db.NhanVien.Any(e => e.staff_email == email.Text))
                {
                    toolTip1.Show("Email đã tồn tại trong hệ thống.", email, 0, 0, 3000);
                    email.Focus();
                    return;
                }
                // Tạo một đối tượng nhân viên mới
                Staff newStaff = new Staff()
                {
                    full_name = hoten.Text,
                    staff_email = email.Text,
                    phone_number = Convert.ToInt32(sdt.Text),
                    staff_address = diachi.Text,
                    date_of_birth = birthday,
                    staff_gender = gioiTinh.Text,
                    role_id = Convert.ToInt64(chucvu.SelectedValue),
                    password = password.Text,
                    created_at = DateTime.Now
                };

                // Thêm nhân viên mới vào cơ sở dữ liệu
                db.NhanVien.Add(newStaff);
                db.SaveChanges();
                if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                {
                    string ext = txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."), txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                    newStaff.staff_image = newStaff.id + ext;
                    pictureBox1.Image.Save(Utility.ImagePath + newStaff.id + ext);
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }

                MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form thêm nhân viên
                this.Close();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại. Error: " + ex.Message, btnSave, 0, 0, 5000);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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
    }
}