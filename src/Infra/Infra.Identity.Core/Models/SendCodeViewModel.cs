using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Infra.Identity.Core.Models
{
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}