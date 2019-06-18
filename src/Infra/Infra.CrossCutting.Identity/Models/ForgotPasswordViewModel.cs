using System.ComponentModel.DataAnnotations;

namespace Infra.CrossCutting.Identity.Models
{
    public class ForgotPasswordViewModel
    {
        //[Required]
        //[EmailAddress]
        //[Display(Name = "Email")]
        public string Email { get; set; }
    }
}
