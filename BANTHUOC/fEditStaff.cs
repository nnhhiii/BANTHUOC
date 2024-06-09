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
            try
            {
                // Cập nhật thông tin của nhân viên từ các control trên form
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
