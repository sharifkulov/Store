using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Stock
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Размер")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Количество")]
        public int Qty { get; set; }

        [Required]
        [Display(Name = "Продукт")]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public bool IsLastElementOrdered { get; set; } = false;


    }
}
