using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ANC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,50, ErrorMessage = "Display Order must be between 1 and 50 characters")]

        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
