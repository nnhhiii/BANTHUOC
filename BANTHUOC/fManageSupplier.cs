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
    public partial class fManageSupplier : Form
    {
        public fManageSupplier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewSupplier"))
                return;
            fNewSupplier f = new fNewSupplier();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.NhaCungCap.Where(c => c.supplier_name.Contains(txtName.Text)).ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    using (var db = new EFDbContext())
                    {
                        Supplier supplier = db.NhaCungCap.Single(c => c.id == id);
                        if (MessageBox.Show("Bạn muốn xóa nhà cung cấp " + supplier.supplier_name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.NhaCungCap.Remove(supplier);
                            db.SaveChanges();
                            fManageSupplier_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditSupplier"))
                    return;
                fEditSupplier f = new fEditSupplier(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["id"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void fManageSupplier_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.NhaCungCap.ToList();
            }
        }
    }
}
