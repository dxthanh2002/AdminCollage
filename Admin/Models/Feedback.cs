using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models
{
    public class Feedback 
    {
        [Key] public int Id { get; set; }

        [Required] public string FullName { get; set; }
        [Required, EmailAddress] public string Email { get; set; }
        [Required] public DateTime Date { get; set; }
        [Column(TypeName = "ntext")] public string? FirstQuestion { get; set; }
        [Column(TypeName = "ntext")] public string? SecondQuestion { get; set; }
        [Column(TypeName = "ntext")] public string? OtherQuestion { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

    }
}
