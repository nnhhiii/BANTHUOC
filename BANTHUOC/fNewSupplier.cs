using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BANTHUOC.Models;

namespace BANTHUOC
{
    public partial class fNewSupplier : Form
    {
        private EFDbContext db = new EFDbContext();
        public fNewSupplier()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên nhà cung cấp", txtName, 0, 0, 3000);
                txtName.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ nhà cung cấp", txtAddress, 0, 0, 3000);
                txtAddress.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                toolTip1.Show("Hãy nhập số điện thoại nhà cung cấp", txtPhoneNumber, 0, 0, 3000);
                txtPhoneNumber.Focus();
                return;
            }
            else if (!int.TryParse(txtPhoneNumber.Text, out int phoneNumber))
            {
                toolTip1.Show("Số điện thoại không hợp lệ", txtPhoneNumber, 0, 0, 3000);
                txtPhoneNumber.Focus();
                return;
            }
            try
            {
                // Tạo một đối tượng mới
                Supplier supplier = new Supplier()
                {
                    supplier_name = txtName.Text,
                    address = txtAddress.Text,
                    phone_number = Convert.ToInt32(txtPhoneNumber.Text),
                    description = txtDescription.Text
                };

                // Thêm ncc mới vào cơ sở dữ liệu
                db.NhaCungCap.Add(supplier);
                db.SaveChanges();

                MessageBox.Show("Thêm nhà cung cấp mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form 
                this.Close();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại. Error: " + ex.Message, btnSave, 0, 0, 5000);
            }

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
