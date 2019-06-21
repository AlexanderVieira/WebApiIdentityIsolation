using System.ComponentModel.DataAnnotations;

namespace Infra.Identity.Core.Models
{ 
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}