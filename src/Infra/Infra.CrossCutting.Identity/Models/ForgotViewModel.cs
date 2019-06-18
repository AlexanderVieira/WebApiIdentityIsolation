using System.ComponentModel.DataAnnotations;

namespace Infra.CrossCutting.Identity.Models
{
    public class ForgotViewModel
    {
        //[Required]
        //[Display(Name = "Email")]
        public string Email { get; set; }
    }
}