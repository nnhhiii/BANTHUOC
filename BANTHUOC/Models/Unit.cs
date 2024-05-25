using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    internal class Unit
    {
        [Key]
        public long id { get; set; }
        public string unit_name { get; set; }
    }
}
