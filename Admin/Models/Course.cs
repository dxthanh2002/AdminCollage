using Admin.Models.Enums;
using System.ComponentModel;
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
        [DisplayName("Duration")]
        public string? DurationYear { get; set; }
        [DisplayName("Criteria")]
        public string EligibilityCriteria { get; set; }
        public virtual List<Student>? Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public Status Status { get; set; }
        [DisplayName("Create Time")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Create Id")]

        public DateTime LastModifiedAt { get; set; }


    }
}
