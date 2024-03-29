﻿using System.ComponentModel.DataAnnotations;

namespace Infra.Identity.Core.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}