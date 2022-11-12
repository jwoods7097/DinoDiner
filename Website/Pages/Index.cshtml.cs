using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Data;

namespace Website.Pages
{
    /// <summary>
    /// Menu Page for Dino Diner website
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The logger for the page
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
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
