#pragma checksum "C:\Users\AsRock\source\repos\Shop\UI\ShopUi\Views\Products\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34b9b65841b11742f7b4d8ed18ad228e31600bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ProductDetails), @"mvc.1.0.view", @"/Views/Products/ProductDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\AsRock\source\repos\Shop\UI\ShopUi\Views\_ViewImports.cshtml"
using ShopUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AsRock\source\repos\Shop\UI\ShopUi\Views\_ViewImports.cshtml"
using ShopUi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34b9b65841b11742f7b4d8ed18ad228e31600bae", @"/Views/Products/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09cec026f28ac0bfb0bf02af0296f6673fd345a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopUi.ViewModels.ProductDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AsRock\source\repos\Shop\UI\ShopUi\Views\Products\ProductDetails.cshtml"
  
    ViewData["Title"] = "Product Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex flex-row justify-content-center align-items-center\">\r\n    <div class=\"d-flex flex-column align-items-center p-2\">\r\n        <h1>");
#nullable restore
#line 9 "C:\Users\AsRock\source\repos\Shop\UI\ShopUi\Views\Products\ProductDetails.cshtml"
       Write(Model.SelectedProduct.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <img class=\"card-img-top card-image\"");
            BeginWriteAttribute("src", " src=\"", 374, "\"", 408, 1);
#nullable restore
#line 10 "C:\Users\AsRock\source\repos\Shop\UI\ShopUi\Views\Products\ProductDetails.cshtml"
WriteAttributeValue("", 380, Model.SelectedProduct.Image, 380, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 409, "\"", 443, 1);
#nullable restore
#line 10 "C:\Users\AsRock\source\repos\Shop\UI\ShopUi\Views\Products\ProductDetails.cshtml"
WriteAttributeValue("", 415, Model.SelectedProduct.Title, 415, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div>");
#nullable restore
#line 11 "C:\Users\AsRock\source\repos\Shop\UI\ShopUi\Views\Products\ProductDetails.cshtml"
        Write(Model.SelectedProduct.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"d-flex flex-column align-items-center p-2\">\r\n            <h1>");
#nullable restore
#line 13 "C:\Users\AsRock\source\repos\Shop\UI\ShopUi\Views\Products\ProductDetails.cshtml"
           Write(string.Format("{0:C2}", Model.SelectedProduct.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <button class=\"btn btn-success\">Buy It Now!</button>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopUi.ViewModels.ProductDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591