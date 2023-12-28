using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models
{
    public class PreviousEducation 
    {
        [Key] public int Id { get; set; }
        public string University { get; set; }
        public string EnrollmentNumber { get; set; }
        public string Center { get; set; }
        public string Stream { get; set; }
        public string Field { get; set; }
        [Column(TypeName = "decimal")] public decimal MarksObtained { get; set; }
        [Column(TypeName = "decimal")] public decimal TotalMarks { get; set; }
        public string ClassObtained { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
