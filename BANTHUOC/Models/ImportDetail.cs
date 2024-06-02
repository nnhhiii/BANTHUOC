using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    internal class ImportDetail
    {
        [Key]
        public long id { get; set; }
        public long import_invoice_id { get; set; }
        public long drug_id { get; set; }
        public decimal import_price { get; set; }
        public int quantity { get; set; }
        public decimal amount { get; set; }
        public DateTime expiry_date { get; set; }
    }
}
