using Microsoft.AspNetCore.Http;
using Store.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.ViewModels
{
    public class ProductFormViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Color> Colors { get; set; }
        public List<Sex> Sexes { get; set; }




        [Display(Name = "Фотография")]
        public IFormFile Photo { get; set; }

        [Display(Name = "Фотография")]
        public string PhotoPath { get; set; }


        public int Id { get; set; }

        [Display(Name = "Категория")]
        [Required(ErrorMessage = "Не выбран тип")]
        public int CategoryId { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Не выбрано название")]
        public string Name { get; set; }


        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Не выбрана цена")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [RegularExpression("([0-9,]+)", ErrorMessage ="Цена должна состоять и чисел")]

        public string Price { get; set; }

        [Required(ErrorMessage = "Не выбран цвет")]
        [Display(Name = "Цвет")]
        public int? ColorId { get; set; }

        [Required(ErrorMessage = "Не выбран бренд")]
        [Display(Name = "Бренд")]
        public int? BrandId { get; set; }

        [Display(Name = "Пол")]
        [Required(ErrorMessage = "Не выбран пол")]
        public int SexId { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}