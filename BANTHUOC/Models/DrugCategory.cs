using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    internal class DrugCategory
    {
        [Key]
        public long category_id { get; set; }
        public string category_name { get; set; }
        public string description { get; set; }

    }
}
