// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GForumBelarus.WebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Components\PostList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Components\PostList.razor"
using GForumBelarus.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Components\PostList.razor"
using GForumBelarus.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class PostList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\CourseWork\GForumBelarus\GForumBelarus.WebSite\Components\PostList.razor"
       
	Post selectedPost;
	string selectPostId;

	void SelectPost(string postId)
	{
		selectPostId = postId;
		selectedPost = PostService.GetPosts().First(x => x.Id == postId);
		GetCurrentRating();
		GetCurrentComments();
	}

	int currentRating = 0;
	int CurrentCom = 0;
	int voteCount = 0;
	string comLabel;
	int comCount = 0;
	string voteLabel;
	string commentaryonform;
	string username;
	List<string> CommentsList = new List<string>();
	List<string> CommentsUser = new List<string>();

	void GetCurrentRating()
	{
		if (selectedPost.Ratings == null)
		{
			currentRating = 0;
			voteCount = 0;
		}
		else
		{
			voteCount = selectedPost.Ratings.Count();
			voteLabel = voteCount > 1 ? "Оценок" : "Оценка";
			currentRating = selectedPost.Ratings.Sum() / voteCount;
		}
	}

	void GetCurrentComments()
	{
		if (selectedPost.Comments == null)
		{
			CurrentCom = 0;
			comCount = 0;
		}
		else
		{
			comCount = selectedPost.Comments.Count();
			comLabel = comCount > 1 ? "Комментариев" : "Комментарий";
			CommentsList.Clear();
			CommentsUser.Clear();
			foreach (string comment in selectedPost.Comments)
			{
				string[] divided = comment.Split(':');
				CommentsList.Add(divided[1]);
					CommentsUser.Add(divided[0]);
					}
				}
			}
			void SubmitRating(int rating)
			{
				PostService.AddRating(selectPostId, rating);
				SelectPost(selectedPost.Id);

			
			}

				void SubmitComment(string comm, string user)
			{
				PostService.AddComment(selectPostId, comm, user);
				SelectPost(selectedPost.Id);			
			}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFilePostService PostService { get; set; }
    }
}
#pragma warning restore 1591
