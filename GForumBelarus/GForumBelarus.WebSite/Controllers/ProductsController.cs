using ForumGuide.WebSite.Services;
using GForumBelarus.WebSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GForumBelarus.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        public ProductsController(JsonFileProductService productService) //ProductService is now an object of class JsonFileProductService
        {
            this.ProductService = productService;

        }

        public JsonFileProductService ProductService { get; }

        public IEnumerable<Product> Get()  //call out getproducts from JsonFileProductService
        {  
            return ProductService.GetProducts(); 
        }

        //[HttpPatch] "[FromBody]"
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string ProductId,
            [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();

        }

    }

}
