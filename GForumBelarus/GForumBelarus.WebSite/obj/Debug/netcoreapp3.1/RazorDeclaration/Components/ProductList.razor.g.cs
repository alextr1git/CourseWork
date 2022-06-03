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
#line 1 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
using GForumBelarus.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
using GForumBelarus.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
       
	Product selectedProduct;
	string selectProductId;

	void SelectProduct(string productId)
	{
		selectProductId = productId;
		selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
		GetCurrentRating();
	}

	int currentRating = 0;
	int voteCount = 0;
	string voteLabel;

	void GetCurrentRating()
	{
		if (selectedProduct.Ratings == null)
		{
			currentRating = 0;
			voteCount = 0;
		}
		else
		{
			voteCount = selectedProduct.Ratings.Count();
			voteLabel = voteCount > 1 ? "Votes" : "Vote";
			currentRating = selectedProduct.Ratings.Sum() / voteCount;
		}
	}

	void SubmitRating(int rating)
	{
		System.Console.WriteLine($"Rating received for {selectedProduct.Id}: {rating}");
		ProductService.AddRating(selectProductId, rating);
		SelectProduct(selectedProduct.Id);
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
