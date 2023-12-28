using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class SectionData 
    {
        [Key] public int Id { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
