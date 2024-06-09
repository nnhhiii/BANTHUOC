using BANTHUOC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fNewStaff : Form
    {
        DateTime birthDate;
        public fNewStaff()
        {
            InitializeComponent();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hoten.Text))
            {
                toolTip1.Show("Hãy nhập họ và tên", hoten, 0, 0, 1000);
                hoten.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(email.Text))
            {
                toolTip1.Show("Hãy nhập email", email, 0, 0, 1000);
                email.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(sdt.Text))
            {
                toolTip1.Show("Hãy nhập số điện thoại", sdt, 0, 0, 1000);
                sdt.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(diachi.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ", diachi, 0, 0, 1000);
                diachi.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(ngaysinh.Text))
            {
                toolTip1.Show("Hãy chọn ngày sinh", ngaysinh, 0, 0, 1000);
                ngaysinh.Focus();
                return;
            }
            else if (!DateTime.TryParseExact(ngaysinh.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthDate))
            {
                toolTip1.Show("Ngày sinh không hợp lệ", ngaysinh, 0, 0, 1000);
                ngaysinh.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(gioitinh.Text))
            {
                toolTip1.Show("Hãy chọn giới tính", gioitinh, 0, 0, 1000);
                gioitinh.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(chucvu.Text))
            {
                toolTip1.Show("Hãy chọn chức vụ", chucvu, 0, 0, 1000);
                chucvu.Focus();
                return;
            }

            try
            {
                // Tạo một đối tượng nhân viên mới
                Staff newStaff = new Staff()
                {
                    full_name = hoten.Text,
                    email = email.Text,
                    phone_number = int.Parse(sdt.Text),
                    address = diachi.Text,
                    date_of_birth = birthDate, 
                    gender = gioitinh.Text,
                    role_id = (chucvu.Text == "Quản lý") ? 1 : 2
                };

                using (var db = new EFDbContext())
                {
                    // Thêm nhân viên mới vào cơ sở dữ liệu
                    db.Set<Staff>().Add(newStaff);
                    db.SaveChanges();
                }

                MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form thêm nhân viên
                this.Close();
            }
            catch (Exception ex)
            {
                string errorMessage = "Đã xảy ra lỗi khi thêm nhân viên mới: ";
                if (ex.InnerException != null)
                {
                    errorMessage += ex.InnerException.Message;
                }
                else
                {
                    errorMessage += ex.Message;
                }
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
