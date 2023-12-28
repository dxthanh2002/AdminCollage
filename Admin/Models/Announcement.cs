using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Announcement
    {
        [Key] public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Published_date { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
