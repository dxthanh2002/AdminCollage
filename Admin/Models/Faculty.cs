using System.Collections;
using Admin.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models
{
    public class Faculty
    {
        [Key] public int Id { get; set; }
        public string? Name { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        [Column(TypeName = "ntext")] public string? Description { get; set; }
        [Column(TypeName = "ntext")] public string? Detail { get; set; }
        public string? Thumbnail { get; set; }
        public Status? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? LastModifiedBy { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
