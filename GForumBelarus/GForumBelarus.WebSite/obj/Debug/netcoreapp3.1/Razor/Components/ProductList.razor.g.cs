#pragma checksum "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efbda0020f90e8aa3af039217a4d40af74c707ca"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
     foreach (var Product in ProductService.GetProducts())
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "\t\t ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, " \r\n\r\n\t\t\t");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddMarkupContent(8, "\r\n\t\t\t\t");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-img");
            __builder.AddAttribute(11, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 12 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
                                                                     Product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\t\t\t\t");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n\t\t\t\t\t");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "card-title");
#nullable restore
#line 14 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
__builder.AddContent(18, Product.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\t\t\t");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-footer");
            __builder.AddMarkupContent(24, "\r\n\t\t\t\t");
            __builder.OpenElement(25, "small");
            __builder.AddAttribute(26, "class", "text-muted");
            __builder.AddMarkupContent(27, "\r\n\t\t\t\t\t");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
                                      (e => SelectProduct(Product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "data-toggle", "modal");
            __builder.AddAttribute(31, "data-target", "#productModal");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddContent(33, "More info");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\t\t ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 26 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"

	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\"> //stars fonts\r\n\r\n");
#nullable restore
#line 31 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal fade");
            __builder.AddAttribute(41, "id", "productModal");
            __builder.AddAttribute(42, "tabindex", "-1");
            __builder.AddAttribute(43, "role", "dialog");
            __builder.AddAttribute(44, "aria-labelledby", "productTitle");
            __builder.AddAttribute(45, "aria-hidden", "true");
            __builder.AddMarkupContent(46, "\r\n\t");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(49, "role", "document");
            __builder.AddMarkupContent(50, "\r\n\r\n\t\t");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-content");
            __builder.AddMarkupContent(53, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-header");
            __builder.AddMarkupContent(56, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(57, "h5");
            __builder.AddAttribute(58, "class", "modal-title");
            __builder.AddAttribute(59, "id", "productTitle");
#nullable restore
#line 38 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
__builder.AddContent(60, selectedProduct.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\t\t\t\t\t\t\t");
            __builder.AddMarkupContent(62, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n\t\t\t\t\t\t\t\t<span aria-hidden=\"true\">&times;</span>\r\n\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-body");
            __builder.AddMarkupContent(66, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "card");
            __builder.AddMarkupContent(69, "\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "card-img");
            __builder.AddAttribute(72, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 45 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
                                                                                     selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(73, "\r\n\t\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "card-body");
            __builder.AddMarkupContent(77, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(78, "p");
            __builder.AddAttribute(79, "class", "card-text");
#nullable restore
#line 48 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
__builder.AddContent(80, selectedProduct.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\t\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "modal-footer");
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 53 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
                     if (voteCount == 0)
					{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(88, "\t\t\t\t\t\t");
            __builder.AddMarkupContent(89, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 56 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
					}
					else
					{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "\t\t\t\t\t\t");
            __builder.OpenElement(91, "span");
#nullable restore
#line 59 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
__builder.AddContent(92, voteCount);

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, " ");
#nullable restore
#line 59 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
__builder.AddContent(94, voteLabel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 60 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"

					}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 63 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
                     for (int i = 1; i <= 5; i++)
					{
						var currentStar = i;
						if (i <= currentRating)
						{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(97, "\t\t\t\t\t\t\t");
            __builder.OpenElement(98, "span");
            __builder.AddAttribute(99, "class", "fa-star fa checked");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
                                                                       (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 69 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
						}
						else
						{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(102, "\t\t\t\t\t\t\t");
            __builder.OpenElement(103, "span");
            __builder.AddAttribute(104, "class", "fa-star fa");
            __builder.AddAttribute(105, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
                                                               (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 73 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"
						}
					}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(107, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
#nullable restore
#line 80 "E:\IT&BSUIR\БГУИР\2 КУРС\4 сем\COURSEWORK\GForumBelarus\GForumBelarus.WebSite\Components\ProductList.razor"


}

#line default
#line hidden
#nullable disable
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