using System.Collections.Generic;

namespace BANTHUOC.Models
{
    public class Role
    {
        public long Id { get; set; }
        public string RoleName { get; set; }

        // Navigation property
        public ICollection<Staff> Staffs { get; set; }
    }
}
