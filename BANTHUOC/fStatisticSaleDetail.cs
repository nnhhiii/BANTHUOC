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
    public partial class fStatisticSaleDetail : Form
    {
        EFDbContext db = new EFDbContext();
        long invoiceId;
        public fStatisticSaleDetail(long id)
        {
            InitializeComponent();
            this.invoiceId = id;
        }

        private void fStatisticSaleDetail_Load(object sender, EventArgs e)
        {
            var SaleDetailsReport = from invoiceDetail in db.CTHDBanHang
                                      join invoice in db.HoaDonBanHang on invoiceDetail.invoice_id equals invoice.id
                                      join drug in db.Thuoc on invoiceDetail.drug_id equals drug.id
                                      join supplier in db.NhaCungCap on drug.supplier_id equals supplier.id
                                      join unit in db.DonViTinh on drug.unit_of_measure_id equals unit.id
                                      where invoice.id == invoiceId
                                    select new
                                      {
                                          InvoiceId = invoice.id,
                                          InvoiceDetailId = invoiceDetail.id,
                                          DrugName = drug.drug_name,
                                          SupplierName = supplier.supplier_name,
                                          Content = drug.content,
                                          UnitName = unit.unit_name,
                                          Quantity = invoiceDetail.quantity,
                                          Price = drug.price,
                                          Amount = invoiceDetail.amount,
                                      };

            dataGridView1.DataSource = SaleDetailsReport.ToList();

            // Tính tổng tiền thành tiền
            var totalAmount = SaleDetailsReport.Sum(invoiceDetail => invoiceDetail.Amount);

            // Hiển thị tổng tiền thành tiền lên TextBox
            TongTien.Text = totalAmount.ToString("N2"); // Định dạng số thập phân
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
