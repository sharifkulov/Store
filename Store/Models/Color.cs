using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Название")]
        public string Name { get; set; }
    }
}
