using BANTHUOC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fEditStaff : Form
    {
        private EFDbContext db = new EFDbContext();
        private long id;
        Staff staff;
        public fEditStaff(long id)
        {
            InitializeComponent();
            this.id = id;


        }
        private void fEditStaff_Load(object sender, EventArgs e)
        {
            chucvu.DisplayMember = "role_name";
            chucvu.ValueMember = "id";
            chucvu.DataSource = db.VaiTro
                .Select(c => new { c.id, c.role_name })
                .ToList();

            staff = db.NhanVien.Single(p => p.id == id);
            hoten.Text = staff.full_name;
            email.Text = staff.staff_email;
            sdt.Text = staff.phone_number.ToString();
            diachi.Text = staff.staff_address;
            ngaysinh.Text = staff.date_of_birth.ToShortDateString();
            gioitinh.Text = staff.staff_gender;
            password.Text = staff.password;
            txtImageFile.Text = string.IsNullOrWhiteSpace(staff.staff_image) ? null : Utility.ImagePath + staff.staff_image;
            pictureBox1.ImageLocation = txtImageFile.Text; //Hiển thị hình
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
            else if (string.IsNullOrWhiteSpace(gioitinh.Text))
            {
                toolTip1.Show("Hãy nhập giới tính", gioitinh, 0, 0, 3000);
                gioitinh.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(password.Text))
            {
                toolTip1.Show("Hãy nhập mật khẩu", password, 0, 0, 3000);
                password.Focus();
                return;
            }

            try
            {
                // Cập nhật thông tin nhân viên từ các control trên form
                staff.full_name = hoten.Text;
                staff.staff_email = email.Text;
                staff.phone_number = Convert.ToInt32(sdt.Text);
                staff.staff_address = diachi.Text;
                staff.date_of_birth = DateTime.Parse(ngaysinh.Text);
                staff.staff_gender = gioitinh.Text;
                staff.role_id = Convert.ToInt64(chucvu.SelectedValue);
                staff.staff_image = Path.GetFileName(txtImageFile.Text);

                db.SaveChanges();
                if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                {
                    string ext = txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."), txtImageFile.Text.Length - txtImageFile.Text.LastIndexOf("."));
                    staff.staff_image = staff.id + ext;
                    pictureBox1.Image.Save(Utility.ImagePath + staff.id + ext);
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }

                MessageBox.Show("Thông tin nhân viên đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form chỉnh sửa nhân viên
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
