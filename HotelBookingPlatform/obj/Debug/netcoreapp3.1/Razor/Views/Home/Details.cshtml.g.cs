#pragma checksum "C:\Users\Ariadni\source\repos\HotelBookingPlatform\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58537789cd34c398bbda7ada0e0588a00bb9b52e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Ariadni\source\repos\HotelBookingPlatform\Views\_ViewImports.cshtml"
using HotelBookingPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ariadni\source\repos\HotelBookingPlatform\Views\_ViewImports.cshtml"
using HotelBookingPlatform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58537789cd34c398bbda7ada0e0588a00bb9b52e", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11a5f029c4b2d26ddddf779fc3b47f7fc6208756", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelBookingPlatform.Models.Room>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Ariadni\source\repos\HotelBookingPlatform\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Details</h1>\r\n\r\n<div class=\"room-container\">\r\n\r\n    <div id=\"room-header\">\r\n        <select>\r\n        <h3> ");
#nullable restore
#line 16 "C:\Users\Ariadni\source\repos\HotelBookingPlatform\Views\Home\Details.cshtml"
        Write(Html.DisplayFor(model => model.RoomId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@", Zografou | Reviews: </h3>
    </div>

    <div class=""room-img""><img src=""https://placehold.it/400x250""></div>
    <div class=""room-ul"">
        <ul>
            <li>blah</li>
            <li>blah</li>
            <li>blah</li>
            <li>blah</li>
            <li>blah</li>
        </ul>
    </div>

    <div id=""room-description"">
        <div class=""room-dets"">

            <h3>room-desc</h3>

            <p>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse euismod lectus porttitor, lacinia
                ligula in, dictum quam. Nulla nec risus nibh. Fusce vel erat id ipsum consectetur rutrum. Quisque felis
                augue, venenatis in ex non, malesuada sollicitudin elit. Donec eleifend elementum dui, sed laoreet ex
                cursus vitae. Cras gravida varius lorem, a molestie nulla efficitur pellentesque. Proin tristique, leo
                eget aliquam rhoncus, nibh est laoreet eros, nec sollicitudin risus diam vel massa. Fus");
            WriteLiteral(@"ce ut mauris
                nulla. Ut est metus, finibus nec nunc ut, commodo tristique eros. Praesent ligula tortor, ultrices a
                mattis in, gravida tincidunt odio. Nam bibendum justo eu vulputate porta. In aliquam in est et mattis.
            </p>
        </div>
        <div style=""text-align:right"">
            <input type=""submit"" id=""booking-room-button"" value=""Already booked"" />
        </div>

    </div>

    <div id=""review"">

        <div id=""client_review"">

            <h5>Add reviews</h5>

            <h6> 1. Username_</h6>
            <p>Add time</p>
            <p>Add time</p>
        </div>

    </div>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58537789cd34c398bbda7ada0e0588a00bb9b52e5665", async() => {
                WriteLiteral("\r\n\r\n        <div id=\"room-desc\">\r\n\r\n            <h5>Reviews</h5>\r\n\r\n            <input type=\"text\" id=\"my-review\" />\r\n        </div>\r\n        <div style=\"text-align:center\"><input type=\"submit\" id=\"review-sumbit\" value=\"Submit\" /></div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelBookingPlatform.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591