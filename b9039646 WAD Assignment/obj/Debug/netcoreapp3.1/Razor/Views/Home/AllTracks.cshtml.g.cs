#pragma checksum "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment-master\b9039646-WAD-Assignment-master\b9039646 WAD Assignment\Views\Home\AllTracks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06565030f0f0e6ffea1bbeb796064861607d1285"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllTracks), @"mvc.1.0.view", @"/Views/Home/AllTracks.cshtml")]
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
#line 1 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment-master\b9039646-WAD-Assignment-master\b9039646 WAD Assignment\Views\_ViewImports.cshtml"
using b9039646_WAD_Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment-master\b9039646-WAD-Assignment-master\b9039646 WAD Assignment\Views\_ViewImports.cshtml"
using b9039646_WAD_Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06565030f0f0e6ffea1bbeb796064861607d1285", @"/Views/Home/AllTracks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"038946c8829f28327e655bb934e4b421b3dedcfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllTracks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment-master\b9039646-WAD-Assignment-master\b9039646 WAD Assignment\Views\Home\AllTracks.cshtml"
  
    ViewData["Title"] = "All Tracks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Displays all tracks below</h1>\n\n");
#nullable restore
#line 8 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment-master\b9039646-WAD-Assignment-master\b9039646 WAD Assignment\Views\Home\AllTracks.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment-master\b9039646-WAD-Assignment-master\b9039646 WAD Assignment\Views\Home\AllTracks.cshtml"
  Write(item.TrackName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 11 "C:\Users\LabStudent-55-504266\Desktop\b9039646-WAD-Assignment-master\b9039646-WAD-Assignment-master\b9039646 WAD Assignment\Views\Home\AllTracks.cshtml"
}

#line default
#line hidden
#nullable disable
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
