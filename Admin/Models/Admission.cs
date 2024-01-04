using Admin.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Admin.Models
{
    public class Admission
    {
        [Key] public int Id { get; set; }
        [DisplayName("Student name")]
        public string Name { get; set; }
        [DisplayName("Father")]
        public string FatherName { get; set; }
        [DisplayName("Mother")]
        public string MotherName { get; set; }
        [DisplayName("Birth day")]

        [Column(TypeName = "date")] public DateTime Dob { get; set; }
        [DisplayName("Gender")]
        public Gender Gender { get; set; }
        [DisplayName("Resident Address")]
        public string ResAddress { get; set; }
        [DisplayName("Persident Address")]
        public string PerAddress { get; set; }
        [DisplayName("Admissions")]
        public string AdmissionFor { get; set; }
        [DisplayName("University")]
        public string University { get; set; }
        [DisplayName("Enroll Number")]
        public string EnrollmentNumber { get; set; }
        [DisplayName("Center")]
        public string Center { get; set; }
        [DisplayName("Stream")]
        public string Stream { get; set; }
        [DisplayName("Field")]
        public string Field { get; set; }
        [DisplayName("Mark")]
        public string MarkSecured { get; set; }
        [DisplayName("Out of")]
        public string OutOf { get; set; }
        [DisplayName("Class")]
        public string ClassObtained { get; set; }
        [DisplayName("Sport")]
        public string? SportDetail { get; set; }
        [DisplayName("Status")]
        public Status Status { get; set; }
        [DisplayName("Create Time")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Create by")]
        public int CreatedById { get; set; }
        [DisplayName("Last modify time")]
        public DateTime LastModifiedAt { get; set; }
        [DisplayName("Last User modify")]
        public int LastModifiedBy { get; set; }
    }
}
