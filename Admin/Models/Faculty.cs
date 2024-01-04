using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models
{
    public class Faculty 
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public string Defination { get; set; }
        public string Qualification { get; set; }
        public string ContactInformation { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

    }
}
