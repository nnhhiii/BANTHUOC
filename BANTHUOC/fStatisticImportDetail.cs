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
    public partial class fStatisticImportDetail : Form
    {
        EFDbContext db = new EFDbContext();
        long importInvoiceId;
        public fStatisticImportDetail(long id)
        {
            InitializeComponent();
            this.importInvoiceId = id;
        }

        private void fStatisticImportDetail_Load(object sender, EventArgs e)
        {
            var importDetailsReport = from importDetail in db.CTHDNhapHang
                                      join importInvoice in db.HoaDonNhapHang on importDetail.import_invoice_id equals importInvoice.id
                                      join drug in db.Thuoc on importDetail.drug_id equals drug.id
                                      join supplier in db.NhaCungCap on drug.supplier_id equals supplier.id
                                      join unit in db.DonViTinh on drug.unit_of_measure_id equals unit.id
                                      where importInvoice.id == importInvoiceId
                                      select new
                                      {
                                          ImportInvoiceId = importInvoice.id,
                                          ImportDetailId = importDetail.id,
                                          DrugName = drug.drug_name,
                                          SupplierName = supplier.supplier_name,
                                          Content = drug.content,
                                          UnitName = unit.unit_name,
                                          Quantity = importDetail.quantity,
                                          ImportPrice = importDetail.import_price,
                                          ExpiryDate = importDetail.expiry_date
                                      };

            dataGridView1.DataSource = importDetailsReport.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
