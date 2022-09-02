using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PSWebApp.Pages
{
    public class DynamicDataModel : PageModel
    {
        /// <summary>
        /// Message string
        /// </summary>
        public string Message { get; set; }

        public void OnGet()
        {
            this.Message = DateTime.Now.Ticks.ToString();
        }
    }
}
