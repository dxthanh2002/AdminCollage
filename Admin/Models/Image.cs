using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Image : BaseObject

    {
        [Key] public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public string Section { get; set; }
        public string Page { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
