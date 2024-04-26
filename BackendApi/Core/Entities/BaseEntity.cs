using System.ComponentModel.DataAnnotations;

namespace BackendApi.Core.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

        public DateTime UpdateAt { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }

  
}
