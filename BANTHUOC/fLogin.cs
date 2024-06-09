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
            var employee = AuthenticateUser(email, password);
            if (employee != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Kiểm tra role_id và mở form tương ứng
                if (employee.role_id == 1)
                {
                    fMain mainForm = new fMain(employee);
                    mainForm.Show();
                }
                else
                {
                    fMainForEmp mainForEmpForm = new fMainForEmp(employee);
                    mainForEmpForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại email và mật khẩu.");
            }
        }


        private Staff AuthenticateUser(string email, string password)
        {
            // Truy vấn email 
            var employee = db.NhanVien.FirstOrDefault(e => e.email == email);

            if (employee != null)
            {
                if (employee.password == password)
                {
                    return employee;
                }
            }
            return null;
        }
    }
}
