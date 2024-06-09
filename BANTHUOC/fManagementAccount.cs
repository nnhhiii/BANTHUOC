using System;
using System.Windows.Forms;
using BANTHUOC.Models;

namespace BANTHUOC
{
    partial class fManagementAccount : Form
    {
        private Staff loggedInEmployee;

        public fManagementAccount(Staff employee)
        {
            InitializeComponent();

            loggedInEmployee = employee;
            hoten.Text = loggedInEmployee.full_name;
            if (loggedInEmployee.role_id == 1)
            {
                chucvu.Text = "Quản lý";
            }
            else if (loggedInEmployee.role_id == 2)
            {
                chucvu.Text = "Nhân viên";
            }
            email.Text = loggedInEmployee.email;
            sdt.Text = loggedInEmployee.phone_number.ToString();
            diachi.Text = loggedInEmployee.address;
            ngaysinh.Text = loggedInEmployee.date_of_birth.ToShortDateString();
            gioitinh.Text = loggedInEmployee.gender;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
