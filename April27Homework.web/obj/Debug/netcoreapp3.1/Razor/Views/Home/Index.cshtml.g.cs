#pragma checksum "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e96c8e8e612cfbfe3ee5c98aeab62fcd1d2cb398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\_ViewImports.cshtml"
using April27Homework.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\_ViewImports.cshtml"
using April27Homework.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\_ViewImports.cshtml"
using April27Homework.data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e96c8e8e612cfbfe3ee5c98aeab62fcd1d2cb398", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd5a8266a1eaedc4e8b9fa0c14755af68b5b6075", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Image>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<a href=\"/home/addImage\" class=\"btn btn-primary\">Add Image</a>\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-2\">\r\n");
#nullable restore
#line 6 "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\Home\Index.cshtml"
         foreach (var image in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin-bottom:20px;text-align:center\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 274, "\"", 305, 2);
            WriteAttributeValue("", 281, "/home/image?id=", 281, 15, true);
#nullable restore
#line 9 "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 296, image.ID, 296, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4>");
#nullable restore
#line 9 "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\Home\Index.cshtml"
                                                  Write(image.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 352, "\"", 383, 2);
            WriteAttributeValue("", 359, "/home/image?id=", 359, 15, true);
#nullable restore
#line 10 "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 374, image.ID, 374, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img style=\"width:400px\"");
            BeginWriteAttribute("src", " src=\"", 431, "\"", 451, 1);
#nullable restore
#line 11 "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 437, image.Address, 437, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 14 "C:\Users\david\source\repos\April27Homework\April27Homework.web\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Image>> Html { get; private set; }
    }
}
#pragma warning restore 1591
