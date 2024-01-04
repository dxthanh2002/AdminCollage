using Admin.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Teacher 
    {
        [Key] public int Id { get; set; }
        [DisplayName("Teacher Name")]
        public string Name { get; set; }
        [DisplayName("Teacher Email")]
        public string? Email { get; set; }
        [DisplayName("Phone number")]
        public string? Phone { get; set; }
        [DisplayName("Image")]
        public string? Avatar { get; set; }
        [DisplayName("Description")]
        public string? Description { get; set; }
        // public List<Subject> SubjectId { get; set; }
        [DisplayName("Status")]
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }

    }
}

