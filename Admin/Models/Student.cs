using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Student 
    {
        [Key] public int Id { get; set; }
        [Required] public string? Name { get; set; }
        [Required] public string? FatherName { get; set; }
        [Required] public string? MotherName { get; set; }
        [Column(TypeName = "date")][Required] public DateTime Dob { get; set; }
        [Required] public Gender Gender { get; set; }
        public string? ResidentialAddress { get; set; }
        public string? PermanentAddress { get; set; }
        [Range(1970, 2024, ErrorMessage = "Please enter valid integer Number")] public int AdmissionYear { get; set; }
        public string? AdmissionStream { get; set; }
        public string StudentCode { get; set; }
        public string? PreviousEducationId { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
