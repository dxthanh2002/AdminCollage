using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Facility 
    {
        [Key] public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? OpeningHour { get; set; }
        public string? ContactInformation { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
