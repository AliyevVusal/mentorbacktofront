#pragma checksum "C:\Users\Vusal\source\repos\MentorFrontToBack\MentorFrontToBack\Views\Trainers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ed181099683ca8737d2ed25afe923758d6e0aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trainers_Index), @"mvc.1.0.view", @"/Views/Trainers/Index.cshtml")]
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
#line 1 "C:\Users\Vusal\source\repos\MentorFrontToBack\MentorFrontToBack\Views\Trainers\Index.cshtml"
using MentorFrontToBack.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ed181099683ca8737d2ed25afe923758d6e0aa", @"/Views/Trainers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Trainers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Trainer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/trainers/trainer-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- ======= Breadcrumbs ======= -->
<div class=""breadcrumbs"">
    <div class=""container"">
        <h2>Trainers</h2>
        <p>Est dolorum ut non facere possimus quibusdam eligendi voluptatem. Quia id aut similique quia voluptas sit quaerat debitis. Rerum omnis ipsam aperiam consequatur laboriosam nemo harum praesentium. </p>
    </div>
</div>
<!-- End Breadcrumbs -->
<!-- ======= Trainers Section ======= -->
<section id=""trainers"" class=""trainers"">
    <div class=""container"" data-aos=""fade-up"">

        <div class=""row"" data-aos=""zoom-in"" data-aos-delay=""100"">

");
#nullable restore
#line 17 "C:\Users\Vusal\source\repos\MentorFrontToBack\MentorFrontToBack\Views\Trainers\Index.cshtml"
             foreach (var trainer in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\" data-aos=\"zoom-in\" data-aos-delay=\"100\">\r\n                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n                        <div class=\"member\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34ed181099683ca8737d2ed25afe923758d6e0aa5133", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"member-content\">\r\n                                <h4>");
#nullable restore
#line 25 "C:\Users\Vusal\source\repos\MentorFrontToBack\MentorFrontToBack\Views\Trainers\Index.cshtml"
                               Write(trainer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <span>");
#nullable restore
#line 26 "C:\Users\Vusal\source\repos\MentorFrontToBack\MentorFrontToBack\Views\Trainers\Index.cshtml"
                                 Write(trainer.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 28 "C:\Users\Vusal\source\repos\MentorFrontToBack\MentorFrontToBack\Views\Trainers\Index.cshtml"
                               Write(trainer.Titel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <div class=\"social\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1406, "\"", 1413, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1488, "\"", 1495, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1571, "\"", 1578, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1655, "\"", 1662, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-linkedin\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 41 "C:\Users\Vusal\source\repos\MentorFrontToBack\MentorFrontToBack\Views\Trainers\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n<!-- End Trainers Section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Trainer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
