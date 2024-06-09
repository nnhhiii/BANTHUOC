using BANTHUOC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fEditStaff : Form
    {
        private Staff staff;

        public fEditStaff(Staff staff)
        {
            InitializeComponent();

            this.staff = staff;

            // Điền thông tin của nhân viên vào các điều khiển trên form
            hoten.Text = staff.full_name;
            email.Text = staff.email;
            sdt.Text = staff.phone_number.ToString();
            diachi.Text = staff.address;
            ngaysinh.Text = staff.date_of_birth.ToShortDateString();
            gioitinh.Text = staff.gender;

            // Kiểm tra và hiển thị chức vụ của nhân viên
            if (staff.role_id == 1)
            {
                chucvu.Text = "Quản lý";
            }
            else if (staff.role_id == 2)
            {
                chucvu.Text = "Nhân viên";
            }
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
            else if (string.IsNullOrWhiteSpace(gioitinh.Text))
            {
                toolTip1.Show("Hãy chọn giới tính", gioitinh, 0, 0, 1000);
                gioitinh.Focus();
                return;
            }

            try
            {
                // Cập nhật thông tin nhân viên từ các control trên form
                staff.full_name = hoten.Text;
                staff.email = email.Text;
                staff.phone_number = int.Parse(sdt.Text);
                staff.address = diachi.Text;
                staff.date_of_birth = DateTime.Parse(ngaysinh.Text);
                staff.gender = gioitinh.Text;

                using (var db = new EFDbContext())
                {
                    db.Entry<Staff>(staff).State = EntityState.Modified;
                    db.SaveChanges();
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

    }
}
