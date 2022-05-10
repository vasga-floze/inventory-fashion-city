using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inventory_fashion_city.Pages
{
    public class InventoryModel : PageModel
    {
        private readonly ILogger<InventoryModel> _logger;

        public InventoryModel(ILogger<InventoryModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
