using Admin.Models.Enums;

namespace Admin.Models;

public class AdmissionResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string? FatherName { get; set; }
    public string? MotherName { get; set; }
    public DateTime Dob { get; set; }
    public Gender Gender { get; set; }
    public string ResAddress { get; set; }
    public string PerAddress { get; set; }
    public int AdmissionFor { get; set; }
    public string Department { get; set; }
    public string? University { get; set; }
    public string? EnrollmentNumber { get; set; }
    public string? Center { get; set; }
    public string? Stream { get; set; }
    public string? Field { get; set; }
    public string? MarkSecured { get; set; }
    public string? OutOf { get; set; }
    public string? ClassObtained { get; set; }
    public string? SportDetail { get; set; }
    public Status Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public int CreatedById { get; set; }
    public DateTime LastModifiedAt { get; set; }
    public int LastModifiedBy { get; set; }
}