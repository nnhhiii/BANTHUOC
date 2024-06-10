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
using System.Xml.Linq;

namespace BANTHUOC
{
    public partial class fManageAccount : Form
    {
        EFDbContext db = new EFDbContext();
        private Staff loggedInEmployee;
        public fManageAccount(Staff loggedInEmployee)
        {
            InitializeComponent();
            this.loggedInEmployee = loggedInEmployee;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fManageAccount_Load(object sender, EventArgs e)
        {
            if (loggedInEmployee == null)
            {
                MessageBox.Show("Không thể tải thông tin nhân viên.");
                return;
            }

            var staff = db.NhanVien.SingleOrDefault(p => p.id == loggedInEmployee.id);
            if (staff != null)
            {
                hoTen.Text = staff.full_name;
                email.Text = staff.staff_email;
                sdt.Text = staff.phone_number.ToString();
                diaChi.Text = staff.staff_address;
                ngaySinh.Text = staff.date_of_birth.ToShortDateString();
                gioiTinh.Text = staff.staff_gender;

                // Kiểm tra và hiển thị chức vụ của nhân viên
                chucVu.Text = staff.role_id == 1 ? "Quản lý" : "Nhân viên";
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên.");
            }


        }
    }
}
