using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BANTHUOC.Models
{
    public class Staff
    {
        [Key]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string full_name { get; set; }

        [Required]
        [StringLength(10)]
        public string gender { get; set; }

        [Required]
        public DateTime date_of_birth { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        public int phone_number { get; set; }

        [ForeignKey("Role")]
        public long role_id { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        [Required]
        public DateTime created_at { get; set; }
    }
}
