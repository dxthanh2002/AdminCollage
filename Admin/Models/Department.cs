using Admin.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Department 
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Head of Department")]
        public string HeadOfDepartment { get; set; }
        [DisplayName("Contact information")]
        public string ContactInformation { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        public Status Status { get; set; }
        [DisplayName("Create Time")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Last Modified")]
        public int CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
