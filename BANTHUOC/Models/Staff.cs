using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC.Models
{
    public class Staff
    {
        public long id { get; set; }
        public string full_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public int phone_number { get; set; }
        public long role_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }

        // Navigation property
        public Role VaiTro { get; set; }
    }
}
