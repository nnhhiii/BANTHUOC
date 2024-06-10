using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    public class InvoiceDetailDisplay
    {
        public long MaThuoc { get; set; }
        public string DrugName { get; set; }
        public string SupplierName { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string UnitName { get; set; }
        public decimal Amount { get; set; }
    }
}
