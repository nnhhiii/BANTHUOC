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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BANTHUOC
{
    public partial class fEditSupplier : Form
    {
        EFDbContext db = new EFDbContext();
        Supplier supplier;
        long id;
        public fEditSupplier(long id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void fEditSupplier_Load(object sender, EventArgs e)
        {
            supplier = db.NhaCungCap.Single(p => p.id == id);
            Text += " - Mã Nhà Cung Cấp " + supplier.id.ToString();
            txtName.Text = supplier.supplier_name;
            txtDescription.Text = supplier.description;
            txtAddress.Text = supplier.address;
            txtPhoneNumber.Text = supplier.phone_number.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên nhà cung cấp?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            try
            {
                supplier.supplier_name = txtName.Text;
                supplier.description = txtDescription.Text;
                supplier.address = txtAddress.Text;
                supplier.phone_number = int.Parse(txtPhoneNumber.Text);
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btnSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
            }
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
