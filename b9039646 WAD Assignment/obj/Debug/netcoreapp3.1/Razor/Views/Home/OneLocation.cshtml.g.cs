#pragma checksum "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db0dc7abda7862b167cff35c0b05e93ae132ed0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneLocation), @"mvc.1.0.view", @"/Views/Home/OneLocation.cshtml")]
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
#line 1 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\_ViewImports.cshtml"
using b9039646_WAD_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\_ViewImports.cshtml"
using b9039646_WAD_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db0dc7abda7862b167cff35c0b05e93ae132ed0", @"/Views/Home/OneLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"038946c8829f28327e655bb934e4b421b3dedcfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneLocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToFavourites", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml"
   
    string backgroundImage = "";

    if (Model.Continent == "Africa")
    {
        backgroundImage = "/images/Africa.png";
    }
    if (Model.Continent == "Latin America and the Caribbean")
    {
        backgroundImage = "/images/South_America.png";
    }
    if (Model.Continent == "Europe and North America")
    {
        if(Model.Country == "United States of America")
        {
            backgroundImage = "/images/North_America.png";
        }
        else { backgroundImage = "/images/Europe.png"; }

    }
    if (Model.Continent == "Asia and the Pacific" || Model.Continent == "Arab States")
    {

        backgroundImage = "/images/Asia.png";

    }
    if (Model.Country == "Australia" || Model.Country == "New Zealand,New Zealand,New Zealand")
    {

        backgroundImage = "/images/Australia.png";

    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db0dc7abda7862b167cff35c0b05e93ae132ed06156", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3db0dc7abda7862b167cff35c0b05e93ae132ed06418", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <style>\n        body {\n\n     \n            background-image: url(");
#nullable restore
#line 47 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml"
                             Write(backgroundImage);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\n            background-repeat:no-repeat;\n            background-size:100% 100%;\n                     \n\n\n\n\n        }\n\n    </style>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db0dc7abda7862b167cff35c0b05e93ae132ed08826", async() => {
                WriteLiteral(@"
     <table class=""table"">
        <tr>
            <td>Name</td>
            <td>Description</td>
            <td>Area</td>
            <td>Country</td>
            <td>Continent</td>
            <td>Geographical Co-ordinates</td>
        </tr>

        <tr>
            <td>");
#nullable restore
#line 73 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 74 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 75 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml"
           Write(Model.Area);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 76 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml"
           Write(Model.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 77 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml"
           Write(Model.Continent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 78 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml"
           Write(Model.GeographicalCoordinates);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n\n\n        </tr>\n\n\n\n     </table>\n\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db0dc7abda7862b167cff35c0b05e93ae132ed011285", async() => {
                    WriteLiteral("Add to Favourites");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-GeographicalCoordinates", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment\b9039646-WAD-Assignment\b9039646 WAD Assignment\Views\Home\OneLocation.cshtml"
                                                                                  WriteLiteral(Model.GeographicalCoordinates);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GeographicalCoordinates"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-GeographicalCoordinates", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GeographicalCoordinates"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
