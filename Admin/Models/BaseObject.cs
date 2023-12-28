using Admin.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models
{
    public class BaseObject
    {
        public Status Status { get; set; }
        [Column(TypeName = "date")] public DateTime CreatedDate { get; set; }
        public int CreatedById { get; set; }
        [Column(TypeName = "date")] public DateTime LastModifiedDate { get; set; }
        public int LastModifiedBy { get; set; }
    }
}
