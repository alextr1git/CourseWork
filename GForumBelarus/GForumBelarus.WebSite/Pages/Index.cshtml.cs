using GForumBelarus.WebSite.Services;
using GForumBelarus.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GForumBelarus.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileProductService ProductService; //variable named by service name
        public IEnumerable<Product> Products { get; private set; } // only there we can put data to out list of objects
        public IndexModel(
            ILogger<IndexModel> logger,     // asking for pre-installed logger as for any other services we want
            JsonFileProductService productService) // anyone who will ask for service will get it
        {
            _logger = logger;
            ProductService = productService;   
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
