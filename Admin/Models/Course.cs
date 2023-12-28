using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models
{
    public class Course
    {
        [Key] public int Id { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "ntext")] public string Detail { get; set; }
        [Required] public string Name { get; set; }
        public string? DurationYear { get; set; }
        public string EligibilityCriteria { get; set; }
        public virtual List<Student>? Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
