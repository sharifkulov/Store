using Microsoft.AspNetCore.Http;
using Store.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.ViewModels
{
    public class UserFormViewModel
    {
        public IEnumerable<Gender> Genders { get; set; }

        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Имя")]
        [MaxLength(25)]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Фамилия")]
        [MaxLength(25)]
        public string LastName { get; set; }



        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Пол")]
        public int GenderId { get; set; }

        public IFormFile Photo { get; set; }
        public string PhotoPath { get; set; }


        [Display(Name = "Адрес 1")]
        public string Address1 { get; set; }

        [Display(Name = "Адрес 2")]
        public string Address2 { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Индекс")]
        public string PostCode { get; set; }

        public string Email { get; set; }



    }
}
