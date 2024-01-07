using Admin.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models
{
    public class Faculty 
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public virtual  Department? Department { get; set; }
        [DisplayName("Defiantion")]
        public string Defination { get; set; }
        public string Qualification { get; set; }
        [DisplayName("Conact Information")]
        public string ContactInformation { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        [DisplayName("Last modified")]
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }

    }
}
