using Admin.Models.Enums;
using System.ComponentModel;

namespace Admin.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string FullName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Comment")]
        public string Comment { get; set; }
        [DisplayName("Status")]
        public Status Status { get; set; }
        [DisplayName("Modify Time")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Create id")]
        public int CreatedById { get; set; }
        [DisplayName("Last Modify Time")]
        public DateTime LastModifiedAt { get; set; }
        [DisplayName("Last Modify User")]
        public int LastModifiedBy { get; set; }
    }
}
