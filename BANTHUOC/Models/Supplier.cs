using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    internal class Supplier
    {
        [Key]
        public long id { get; set; }
        public string supplier_name { get; set; }
        public string description { get; set; }
        public string address { get; set; }
        public int phone_number { get; set; }

    }
}
