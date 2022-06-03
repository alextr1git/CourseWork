using GForumBelarus.WebSite.Models;
using GForumBelarus.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GForumBelarus.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public JsonFilePostService PostService { get; }
        public PostController(JsonFilePostService postService) //ProductService is now an object of class JsonFileProductService
        {
            this.PostService = postService;

        }
     
        public IEnumerable<Post> Get()  //call out getproducts from JsonFileProductService
        {  
            return PostService.GetPosts(); 
        }

        //[HttpPatch] "[FromBody]"
        [Route("Rate")] // Данные маршрута в RouteData.Values 
        [HttpGet] 
        public ActionResult Get(
            [FromQuery] string PostId, //Из строки запроса
            [FromQuery] int Rating,
            [FromQuery] string Comment)
        {
            PostService.AddRating(PostId, Rating);
            PostService.AddComment(PostId, Comment);
            return Ok();

        }

    }

}
