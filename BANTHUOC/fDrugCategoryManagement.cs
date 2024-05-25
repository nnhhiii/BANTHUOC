using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BANTHUOC.Models;



namespace BANTHUOC
{
    public partial class fDrugCategoryManagement : Form
    {
        public fDrugCategoryManagement()
        {
            InitializeComponent();

        }

        private void fDrugCategoryManagement_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.LoaiDuocPham.ToList();
            }
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewDrugCategory"))
                return;
            fNewDrugCategory f = new fNewDrugCategory();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                try
                {
                    long category_id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["category_id"].Value);
                    using (var db = new EFDbContext())
                    {
                        DrugCategory drugCategory = db.LoaiDuocPham.Single(c => c.category_id == category_id);
                        if (MessageBox.Show("Bạn muốn xóa loại " + drugCategory.category_name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.LoaiDuocPham.Remove(drugCategory);
                            db.SaveChanges();
                            fDrugCategoryManagement_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                if (Utility.IsOpeningForm("fEditDrugCategory"))
                    return;
                fEditDrugCategory f = new fEditDrugCategory(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["category_id"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
