using System.ComponentModel.DataAnnotations;

namespace Infra.Identity.Core.Models
{ 
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
