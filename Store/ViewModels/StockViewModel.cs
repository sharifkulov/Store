using Store.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.ViewModels
{
    public class StockViewModel
    {
        public int Id { get; set; }

        [Display(Name= "Размер")]
        [Required]
        public string Name { get; set; }

        [Display(Name= "Количество")]
        [Range(0, 10_000)]
        [Required]
        public int Qty { get; set; }

        [Display(Name = "Продукт")]
        [Required]
        public int ProductId { get; set; }

        public List<Stock> Stock { get; set; }


    }
}
