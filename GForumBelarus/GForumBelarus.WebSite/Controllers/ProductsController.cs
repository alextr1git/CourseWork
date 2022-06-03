using GForumBelarus.WebSite.Models;
using GForumBelarus.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GForumBelarus.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductService ProductService { get; }
        public ProductsController(JsonFileProductService productService) //ProductService is now an object of class JsonFileProductService
        {
            this.ProductService = productService;

        }
     
        public IEnumerable<Product> Get()  //call out getproducts from JsonFileProductService
        {  
            return ProductService.GetProducts(); 
        }

        //[HttpPatch] "[FromBody]"
        [Route("Rate")] // Данные маршрута в RouteData.Values 
        [HttpGet] 
        public ActionResult Get(
            [FromQuery] string ProductId, //Из строки запроса
            [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();

        }

    }

}
