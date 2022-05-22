using System.ComponentModel.DataAnnotations;

namespace Store.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Имя")]
        public string RoleName { get; set; }
    }
}
