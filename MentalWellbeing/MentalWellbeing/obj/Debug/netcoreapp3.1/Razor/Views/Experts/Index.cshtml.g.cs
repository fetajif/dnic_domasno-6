#pragma checksum "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5691d77dc16c21f37733e19f84334c9b25455826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experts_Index), @"mvc.1.0.view", @"/Views/Experts/Index.cshtml")]
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
#line 1 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\_ViewImports.cshtml"
using MentalWellbeing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\_ViewImports.cshtml"
using MentalWellbeing.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5691d77dc16c21f37733e19f84334c9b25455826", @"/Views/Experts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da99d24772acf242f337ae3d409bf12103d5e59", @"/Views/_ViewImports.cshtml")]
    public class Views_Experts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MentalWellbeing.Models.Expert>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n");
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th></th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 467, "\"", 487, 1);
#nullable restore
#line 26 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml"
WriteAttributeValue("", 473, item.ImageURL, 473, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 200px;width:300px;\"");
            BeginWriteAttribute("alt", " alt=\"", 523, "\"", 558, 5);
            WriteAttributeValue("", 529, "Image", 529, 5, true);
            WriteAttributeValue(" ", 534, "for", 535, 4, true);
            WriteAttributeValue(" ", 538, "article", 539, 8, true);
#nullable restore
#line 26 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml"
WriteAttributeValue(" ", 546, item.Name, 547, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 557, "!", 557, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 29 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml"
                      
                        var name = item.Name + " " + item.Surname;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h2>");
#nullable restore
#line 32 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    ");
#nullable restore
#line 33 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Biography));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5691d77dc16c21f37733e19f84334c9b254558267149", async() => {
                WriteLiteral("Контактирај");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\User5531\Desktop\6th semester\Dizajn na Interakcija Covek Kompjuter\MentalWellbeing\MentalWellbeing\Views\Experts\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MentalWellbeing.Models.Expert>> Html { get; private set; }
    }
}
#pragma warning restore 1591
