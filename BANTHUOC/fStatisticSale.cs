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
    public partial class fStatisticSale : Form
    {
        private EFDbContext db = new EFDbContext();
        public fStatisticSale()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fStatisticSale_Load(object sender, EventArgs e)
        {
            var saleReport = from invoice in db.HoaDonBanHang
                               join staff in db.NhanVien on invoice.employee_id equals staff.id
                               orderby invoice.id descending
                               select new
                               {
                                   InvoiceId = invoice.id,
                                   CreatedAt = invoice.create_at,
                                   TotalAmount = invoice.total_amount,
                                   StaffFullName = staff.full_name,
                                   StaffEmail = staff.staff_email
                               };
            dataGridView1.DataSource = saleReport.ToList();

            // Tính tổng tiền thành tiền của các hóa đơn
            var totalAmount = saleReport.Sum(invoice => invoice.TotalAmount);

            // Hiển thị tổng tiền thành tiền lên TextBox
            TongTien.Text = totalAmount.ToString("N2"); // Định dạng số thập phân
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "invoiceDetail")
            {
                if (Utility.IsOpeningForm("fStatisticSaleDetail"))
                    return;
                fStatisticSaleDetail f = new fStatisticSaleDetail(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["InvoiceId"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
