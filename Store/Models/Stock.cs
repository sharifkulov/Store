using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Stock
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Размер")]
        // todo zabezpieczyć żeby jeden produkt mógł mieć tylko jeden element o danej nazwie
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
