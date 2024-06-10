using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    internal class Invoice
    {

        [Key]
        public long id { get; set; }
        public decimal total_amount { get; set; }
        public DateTime create_at { get; set; }
        public long employee_id { get; set; }
    }
}
