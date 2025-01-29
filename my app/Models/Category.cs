using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace my_app.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100.")]
        public int Displayorder { get; set; }
    }
}

