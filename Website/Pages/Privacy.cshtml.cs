using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Pages
{
    /// <summary>
    /// Privacy page for Dino Diner website
    /// </summary>
    public class PrivacyModel : PageModel
    {
        /// <summary>
        /// The logger for this page
        /// </summary>
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// OnGet method
        /// </summary>
        public void OnGet()
        {
        }
    }
}
