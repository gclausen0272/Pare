#pragma checksum "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f963147cf4c7d85bedb9f298b4feba42c6689cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application_Populate), @"mvc.1.0.view", @"/Views/Application/Populate.cshtml")]
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
#line 1 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\_ViewImports.cshtml"
using Pare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\_ViewImports.cshtml"
using Pare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f963147cf4c7d85bedb9f298b4feba42c6689cd", @"/Views/Application/Populate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62262097ad5527c4d294841d7047f5d2c4c53ed1", @"/Views/_ViewImports.cshtml")]
    public class Views_Application_Populate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Query>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Poppins"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
");
#nullable restore
#line 5 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
  
    ViewBag.Title = "Populate";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
   
    ViewBag.Title = "New Session? Fill this out and we can get started!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 13 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 14 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
 using(Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"form-group\">\r\n    ");
#nullable restore
#line 16 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(Html.LabelFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(Html.TextBoxFor(model => model.Location, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    ");
#nullable restore
#line 18 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(Html.LabelFor(model => model.Term));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(Html.TextBoxFor(model => model.Term, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    ");
#nullable restore
#line 20 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(Html.LabelFor(model => model.MaxLocations));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 21 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(Html.TextBoxFor(model => model.MaxLocations, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    ");
#nullable restore
#line 22 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(Html.LabelFor(model => model.Enough));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(Html.TextBoxFor(model => model.Enough, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n  </div>\r\n");
            WriteLiteral("     <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n");
#nullable restore
#line 27 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Restaurants in your area</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 31 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
     for (int i = 0; i < ViewBag.NumTimes; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 33 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 34 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</ul>
<h2> Now lets get you Pared! </h2><br>
<b>How does this work: </b><p>all you have to do is swipe right if you would eat there, and swipe left if you wouldn't
    <p>send the pare link below to the person you want to eat with and</p>
</p><p>We'll do the rest, to create the perfect Pare</p>

");
#nullable restore
#line 41 "C:\Users\gclau\OneDrive\Documents\GitHub\Pare\Views\Application\Populate.cshtml"
Write(Html.ActionLink("Find My Pare", "CreateMatches", new { sessionId = ViewBag.sessionId, index = 0, name = ViewBag.first,score = 0,enough = ViewBag.Enough, first = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br><br><br>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Query> Html { get; private set; }
    }
}
#pragma warning restore 1591
