using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    internal class ImportInvoice
    {
        [Key]
        public long id { get; set; }
        public decimal total_amount { get; set; }
        public DateTime creat_at { get; set; }
        public long employee_id { get; set;}
    }
}
