using System;
using System.Linq;
using System.Windows.Forms;
using BANTHUOC.Models;

namespace BANTHUOC
{
    public partial class fLogin : Form
    {
        private EFDbContext db = new EFDbContext(); // Khởi tạo đối tượng DbContext để tương tác với cơ sở dữ liệu

        public fLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            // Gọi phương thức AuthenticateUser để kiểm tra thông tin đăng nhập
            if (AuthenticateUser(email, password))
            {
                MessageBox.Show("Đăng nhập thành công!");

                fMain mainForm = new fMain();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại email và mật khẩu.");
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            // Truy vấn email 
            var employee = db.NhanVien.FirstOrDefault(e => e.staff_email == email);

            if (employee != null)
            {
                if (employee.password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
