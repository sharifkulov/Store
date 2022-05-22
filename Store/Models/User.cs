using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Role : IdentityRole<int> { }


    public class User : IdentityUser<int>
    {
        [Required]
        [Display(Name = "Имя")]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Пол")]
        public int GenderId { get; set; }

        [Display(Name = "Пол")]
        public Gender Gender { get; set; }


        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public override string PhoneNumber { get; set; }


        public string PhotoPath { get; set; }

        [Display(Name = "Алрес 1")]
        public string Address1 { get; set; }

        [Display(Name = "Адрес 2")]
        public string Address2 { get; set; }

        [Display(Name = "Город")]
        public string City { get; set; }

        [Display(Name = "Индекс")]
        public string PostCode { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
