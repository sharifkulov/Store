using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Display(Name="Название")]
        public string Name { get; set; }

        public string PhotoPath { get; set; }
        [Display(Name = "Логотип")]
        [NotMapped]
        public IFormFile Photo { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
