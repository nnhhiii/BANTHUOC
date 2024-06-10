using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BANTHUOC.Models
{
    public class Staff
    {
        [Key]
        public long id { get; set; }
        public string full_name { get; set; }
        public string staff_gender { get; set; }
        public DateTime date_of_birth { get; set; }
        public string staff_address { get; set; }
        public int phone_number { get; set; }
        public long role_id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? staff_email { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }
    }
}
