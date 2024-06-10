using Microsoft.EntityFrameworkCore;
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
    public partial class fStatisticImport : Form
    {
        private EFDbContext db = new EFDbContext();
        public fStatisticImport()
        {
            InitializeComponent();
        }

        private void fStatisticImport_Load(object sender, EventArgs e)
        {
            var importReport = from importInvoice in db.HoaDonNhapHang
                               join staff in db.NhanVien on importInvoice.employee_id equals staff.id
                               orderby importInvoice.id descending
                               select new
                               {
                                   ImportInvoiceId = importInvoice.id,
                                   CreatedAt = importInvoice.create_at,
                                   TotalAmount = importInvoice.total_amount,
                                   StaffFullName = staff.full_name,
                                   StaffEmail = staff.staff_email
                               };


            dataGridView1.DataSource = importReport.ToList();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "importDetail")
            {
                if (Utility.IsOpeningForm("fStatisticImportDetail"))
                    return;
                fStatisticImportDetail f = new fStatisticImportDetail(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ImportInvoiceId"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
