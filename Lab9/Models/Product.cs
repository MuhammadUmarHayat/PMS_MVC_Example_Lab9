using System.ComponentModel.DataAnnotations;

namespace pms_mvc_example.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        [Display(Name = "Image Path")]
        public string Image { get; set; } = string.Empty;

        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        [StringLength(150)]
        public string Status { get; set; } = string.Empty;
    }
}