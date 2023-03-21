using System.ComponentModel.DataAnnotations;

namespace ITS_System.Models
{
    public class Asset
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        [StringLength(25)]
        public string Room { get; set; }

    }
}
