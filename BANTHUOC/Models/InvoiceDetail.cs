using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    internal class InvoiceDetail
    {
        [Key]
        public long id { get; set; }
        public long invoice_id { get; set; }
        public long drug_id { get; set; }
        public int quantity { get; set; }
        public decimal amount { get; set; }
    }
}
