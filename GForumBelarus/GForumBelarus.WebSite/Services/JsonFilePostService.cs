using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using GForumBelarus.WebSite.Models;
using Microsoft.AspNetCore.Hosting;


namespace GForumBelarus.WebSite.Services
{
        public class JsonFilePostService // Allows us to get Objects From JSON database file
        {
            public JsonFilePostService(IWebHostEnvironment webHostEnvironment)
            {
                WebHostEnvironment = webHostEnvironment;
            }

            public IWebHostEnvironment WebHostEnvironment { get; }

            private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "postbase.json"); // universal route to json file 

            public IList<Post> GetPosts() //deserialize JSON to objects as array of Products. Type IEnumerable (JSON->PRODUCTS)
            {
                using var jsonFileReader = File.OpenText(JsonFileName);
                return JsonSerializer.Deserialize<Post[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions // add option to be caseInsensitive
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }

            public void AddRating(string postid, int rating)
            {
                var posts = GetPosts();

                if (posts.First(x => x.Id == postid).Ratings == null) // search of first item with such ID
                {
                    posts.First(x => x.Id == postid).Ratings = new int[] { rating };
                }
                else
                {
                    var ratings = posts.First(x => x.Id == postid).Ratings.ToList(); //list of ratings
                    ratings.Add(rating);
                    posts.First(x => x.Id == postid).Ratings = ratings.ToArray();
                }

                using var outputStream = File.OpenWrite(JsonFileName);

                JsonSerializer.Serialize<IEnumerable<Post>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true, // to accept any language
                        Indented = true
                    }),
                    posts //write down the item with changed rating
                );
            }

            public void AddComment(string postid, string comment, string author)
            {

                var posts = GetPosts();
                string signedcomm = author + ":" + comment;
            if (posts.First(x => x.Id == postid).Comments == null) // search of first item with such ID
                {
                    posts.First(x => x.Id == postid).Comments = new string[] { signedcomm };
                }
                else
                {
                    var existcomments = posts.First(x => x.Id == postid).Comments.ToList(); //list of comments
                
                    existcomments.Add(signedcomm);
                    posts.First(x => x.Id == postid).Comments = existcomments.ToArray();
                }
                    using var outputStream = File.OpenWrite(JsonFileName);

                    JsonSerializer.Serialize<IList<Post>>(
                        new Utf8JsonWriter(outputStream, new JsonWriterOptions
                        {
                            SkipValidation = true, // to accept any language
                            Indented = true
                        }),
                        posts //write down the item with changed rating
            );
            }


        public void AddPost(
            string creator,
            string image,
            string Title,
            string Description,
            string District,
            string Tag,
            string Email)
        {
            Random rnd = new Random();
            DateTime nowdate = DateTime.Now.Date;
            Post NewPost = new Post();
           

            int randvalue = rnd.Next(0, 1000000);
            var posts = GetPosts();

            using var outputStream = File.OpenWrite(JsonFileName);

            NewPost.Id = randvalue.ToString();
            NewPost.Creator = creator;
            NewPost.Image = image;
            NewPost.PublDate = nowdate.Date.ToString("dd/MM/yyyy");
            NewPost.Title = Title;
            NewPost.Description = Description;
            NewPost.Ratings = null;
            NewPost.Comments = null;
            NewPost.District = District;
            NewPost.Tag = Tag;
            NewPost.OwnerEmail = Email;

            IList<Post> newlist = new List<Post>(posts);

             newlist.Add(NewPost);

 
            JsonSerializer.Serialize<IList<Post>>(
                      new Utf8JsonWriter(outputStream, new JsonWriterOptions
                      {
                          SkipValidation = true, // to accept any language
                          Indented = true
                      }),
                      newlist
                      );//write down the item with changed rating
        }
    }
    }
