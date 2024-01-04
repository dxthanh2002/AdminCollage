using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Admin.Models
{
    public class Student 
    {
        [Key] public int Id { get; set; }
        [DisplayName("Full name")]
        [Required] public string? Name { get; set; }
        [DisplayName("Father")]
        [Required] public string? FatherName { get; set; }
        [DisplayName("Mother")]
        [Required] public string? MotherName { get; set; }
        [DisplayName("Birthday")]
        [Column(TypeName = "date")][Required] public DateTime Dob { get; set; }
        [DisplayName("Gender")]
        [Required] public Gender Gender { get; set; }
        [DisplayName("Residential Address")]
        public string? ResidentialAddress { get; set; }
        [DisplayName("Permanent Address")]
        public string? PermanentAddress { get; set; }
        [DisplayName("Admission Year")]

        [Range(1970, 2024, ErrorMessage = "Please enter valid Number (1970-2024)")] public int AdmissionYear { get; set; }
        [DisplayName("Admission Stream")]
        public string? AdmissionStream { get; set; }
        [DisplayName("Student Code")]
        public string StudentCode { get; set; }
        [DisplayName("Student Previous Education")]
        public string? PreviousEducationId { get; set; }
        [DisplayName("Status")]
        public Status Status { get; set; }
        [DisplayName("Create Time")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Create Id")]

        public DateTime LastModifiedAt { get; set; }
  

    }
}
