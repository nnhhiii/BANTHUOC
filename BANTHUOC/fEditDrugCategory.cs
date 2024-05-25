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

namespace BANTHUOC
{
    public partial class fEditDrugCategory : Form
    {
        EFDbContext db = new EFDbContext();
        DrugCategory drugCategory;
        long category_id;
        public fEditDrugCategory(long category_id)
        {
            InitializeComponent();
            this.category_id = category_id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEditDrugCategory_Load(object sender, EventArgs e)
        {
            drugCategory = db.LoaiDuocPham.Single(p => p.category_id == category_id);
            Text += " - Mã Loại Thuốc " + drugCategory.category_id.ToString();
            txtName.Text = drugCategory.category_name;
            txtDescription.Text = drugCategory.description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên loại thuốc?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            try
            {
                drugCategory.category_name = txtName.Text;
                drugCategory.description = txtDescription.Text;
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btnSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
            }
            txtName.Focus();
        }
    }
}
