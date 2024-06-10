using BANTHUOC.Models;
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
    public partial class fStatisticInventory : Form
    {
        private EFDbContext db = new EFDbContext();
        public fStatisticInventory()
        {
            InitializeComponent();
        }

        private void fStatisticInventory_Load(object sender, EventArgs e)
        {
            var inventoryReport  = from drug in db.Thuoc
                                    join importDetail in db.CTHDNhapHang on drug.id equals importDetail.drug_id into importDetails
                                    from id in importDetails.DefaultIfEmpty()
                                    join invoiceDetail in db.CTHDBanHang on drug.id equals invoiceDetail.drug_id into invoiceDetails
                                    from ivd in invoiceDetails.DefaultIfEmpty()
                                    group new { id, ivd } by new { drug.drug_name, drug.DrugCategory.category_name, drug.Supplier.supplier_name, drug.Unit.unit_name, drug.expiry_date, drug.quantity } into grouped
                                    select new
                                    {
                                        DrugName = grouped.Key.drug_name,
                                        CategoryName = grouped.Key.category_name,
                                        SupplierName = grouped.Key.supplier_name,
                                        UnitName = grouped.Key.unit_name,
                                        ExpiryDate = grouped.Key.expiry_date,
                                        TotalImportQuantity = grouped.Sum(g => g.id != null ? g.id.quantity : 0),
                                        TotalSaleQuantity = grouped.Sum(g => g.ivd != null ? g.ivd.quantity : 0),
                                        StockQuantity = grouped.Key.quantity
                                    };


            dataGridView1.DataSource = inventoryReport.ToList();
        }
    }
}
