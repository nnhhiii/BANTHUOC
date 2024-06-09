using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    internal class Drug
    {
        [Key]
        public long id { get; set; }
        public string drug_name { get; set; }
        public long category_id { get; set; }
        public long supplier_id { get; set; }
        public long unit_of_measure_id { get; set; }
        public string? image { get; set; }
        public string content { get; set; }
        public string packing { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public string? description { get; set; }
        public string? usage_instructions { get; set; }
        public string? side_effects { get; set; }
        public string? contraindications { get; set; }
        public DateTime expiry_date { get; set; }


        [ForeignKey("category_id")]
        public virtual DrugCategory DrugCategory { get; set; }
        


        [ForeignKey("supplier_id")]
        public virtual Supplier Supplier { get; set; }


        [ForeignKey("unit_of_measure_id")]
        public virtual Unit Unit { get; set; }
    }

}
