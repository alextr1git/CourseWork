using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using GForumBelarus.WebSite.Models;
using Microsoft.AspNetCore.Hosting;


namespace ForumGuide.WebSite.Services
{
        public class JsonFileProductService // Allows us to get Objects From JSON database file
        {
            public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
            {
                WebHostEnvironment = webHostEnvironment;
            }

            public IWebHostEnvironment WebHostEnvironment { get; }

            private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); // universal route to json file 

            public IEnumerable<Product> GetProducts() //deserialize JSON to objects as array of Products. Type IEnumerable (JSON->PRODUCTS)
            {
                using var jsonFileReader = File.OpenText(JsonFileName);
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions // add option to be caseInsensitive
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }

            public void AddRating(string productId, int rating)
            {
                var products = GetProducts();

                if (products.First(x => x.Id == productId).Ratings == null)
                {
                    products.First(x => x.Id == productId).Ratings = new int[] { rating };
                }
                else
                {
                    var ratings = products.First(x => x.Id == productId).Ratings.ToList();
                    ratings.Add(rating);
                    products.First(x => x.Id == productId).Ratings = ratings.ToArray();
                }

                using var outputStream = File.OpenWrite(JsonFileName);

                JsonSerializer.Serialize<IEnumerable<Product>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    products
                );
            }
        }
    }
