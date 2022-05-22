using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{
    public class Product
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        [Display(Name = "Категория")]
        public Category Category{ get; set; }

        [Required]
        [Display(Name="Название")]
        public string Name { get; set; }

        [Display(Name = "Фотография")]
        public string PhotoPath { get; set; }

        
        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Column(TypeName = "decimal(15,2)")]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Display(Name = "Цвет")]
        public Color Color { get; set; }

        [Display(Name = "Цвет")]
        public int? ColorId { get; set; }


        public Brand Brand { get; set; }
        [Display(Name = "Бренд")]
        public int? BrandId { get; set; }


        [Required]
        [Display(Name = "Пол")]
        public int SexId { get; set; }
        
        [Display(Name = "Тип")]
        public Sex Sex { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [NotMapped]
        public IFormFile Photo{ get; set; }

        public ICollection<Stock> Stock { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
