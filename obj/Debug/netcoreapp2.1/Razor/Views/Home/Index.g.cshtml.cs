#pragma checksum "C:\Users\basic\Desktop\codingDojo\c#\Asp\Dojodachi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebbd705a5cfef1608f5be2a2357886decd0a87cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\basic\Desktop\codingDojo\c#\Asp\Dojodachi\Views\_ViewImports.cshtml"
using Dojodachi;

#line default
#line hidden
#line 2 "C:\Users\basic\Desktop\codingDojo\c#\Asp\Dojodachi\Views\_ViewImports.cshtml"
using Dojodachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbd705a5cfef1608f5be2a2357886decd0a87cd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f823666e3659d58cebeb316cce4284db07d26c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(5, 15, false);
#line 1 "C:\Users\basic\Desktop\codingDojo\c#\Asp\Dojodachi\Views\Home\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(20, 354, true);
            WriteLiteral(@"</h1>
<div class = ""PetBox"">
    <div class=""Buttons"">
        <button ><a href=""/feed""> Feed</a> </button>
        <button ><a href=""/play""> Play</a> </button>
        <button ><a href=""/work""> Work</a> </button>
        <button ><a href=""/sleep""> Sleep</a> </button>
    </div>
    <div class = ""thing"">
        <h4>Happiness</h4>
        <p>");
            EndContext();
            BeginContext(375, 17, false);
#line 11 "C:\Users\basic\Desktop\codingDojo\c#\Asp\Dojodachi\Views\Home\Index.cshtml"
      Write(ViewBag.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(392, 87, true);
            WriteLiteral("</p>\r\n    </div>\r\n        <div class = \"thing\">\r\n        <h4>Fullness</h4>\r\n        <p>");
            EndContext();
            BeginContext(480, 16, false);
#line 15 "C:\Users\basic\Desktop\codingDojo\c#\Asp\Dojodachi\Views\Home\Index.cshtml"
      Write(ViewBag.Fullness);

#line default
#line hidden
            EndContext();
            BeginContext(496, 85, true);
            WriteLiteral("</p>\r\n    </div>\r\n        <div class = \"thing\">\r\n        <h4>Energy</h4>\r\n        <p>");
            EndContext();
            BeginContext(582, 14, false);
#line 19 "C:\Users\basic\Desktop\codingDojo\c#\Asp\Dojodachi\Views\Home\Index.cshtml"
      Write(ViewBag.Energy);

#line default
#line hidden
            EndContext();
            BeginContext(596, 84, true);
            WriteLiteral("</p>\r\n    </div>\r\n        <div class = \"thing\">\r\n        <h4>Meals</h4>\r\n        <p>");
            EndContext();
            BeginContext(681, 13, false);
#line 23 "C:\Users\basic\Desktop\codingDojo\c#\Asp\Dojodachi\Views\Home\Index.cshtml"
      Write(ViewBag.Meals);

#line default
#line hidden
            EndContext();
            BeginContext(694, 24, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
