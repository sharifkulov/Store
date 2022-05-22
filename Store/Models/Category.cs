using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Необходимо ввести название категории")]
        [Display(Name = "Название")]
        public string Name { get; set; }

    }
}
