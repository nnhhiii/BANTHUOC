
using BANTHUOC.Models;
using System.Data;

namespace BANTHUOC
{
    public partial class fManageStaff : Form
    {
        public fManageStaff()
        {
            InitializeComponent();
        }

        private void fManageStaff_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.NhanVien.ToList();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewStaff"))
                return;
            fNewStaff f = new fNewStaff();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.NhanVien.Where(c => c.full_name.Contains(txtName.Text)).ToList();
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
                        Staff staff = db.NhanVien.Single(c => c.id == id);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + staff.full_name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.NhanVien.Remove(staff);
                            db.SaveChanges();
                            fManageStaff_Activated(sender, e);
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
                if (Utility.IsOpeningForm("fEditStaff"))
                    return;
                fEditStaff f = new fEditStaff(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["id"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
