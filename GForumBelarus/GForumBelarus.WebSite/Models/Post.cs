using System.Text.Json;
using System.Text.Json.Serialization;

namespace GForumBelarus.WebSite.Models
{
    public class Post //main class
    {
        /*
        public string Id { get; set; }
        public string Creator { get; set; }

        [JsonPropertyName("img")] //json tag
        public string Image { get; set; }
        public string PublDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }
        //public string[] Comments { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Post>(this); // convert our object data back to Json (PRODUCTS->JSON)
        */
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")] //json tag
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Post>(this); // convert our object data back to Json (PRODUCTS->JSON)

    }
}
