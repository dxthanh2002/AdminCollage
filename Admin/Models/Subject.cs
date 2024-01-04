using Admin.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Subject : BaseObject
    {
        [Key] public int Id { get; set; }
        [DisplayName("Subject Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string? Description { get; set; }
        [DisplayName("Course")]
        public List<Course> Courses { get; set; }
        [DisplayName("Teacher")]
        public List<Teacher> Teachers { get; set; }
        [DisplayName("Status")]
        public Status Status { get; set; }
        [DisplayName("Create time")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("CreateID")]
        public int CreatedById { get; set; }
        [DisplayName("Modify Time")]
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
