#pragma checksum "C:\Dev\fun-com\Views\produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a3d8773cce0f7fc8988862bf1d9375a966769f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_produto_Index), @"mvc.1.0.view", @"/Views/produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/produto/Index.cshtml", typeof(AspNetCore.Views_produto_Index))]
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
#line 1 "C:\Dev\fun-com\Views\_ViewImports.cshtml"
using fun_com;

#line default
#line hidden
#line 2 "C:\Dev\fun-com\Views\_ViewImports.cshtml"
using fun_com.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a3d8773cce0f7fc8988862bf1d9375a966769f9", @"/Views/produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c038c370c853bf23840d64eefff98a6678891498", @"/Views/_ViewImports.cshtml")]
    public class Views_produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<fun_com.Models.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-light float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\fun-com\Views\produto\Index.cshtml"
  
    ViewBag.Title = "Produtos";

#line default
#line hidden
            BeginContext(86, 82, true);
            WriteLiteral("\r\n<div class=\"d-flex justify-content-between pb-3\">\r\n    <h2>Produtos</h2>\r\n\r\n    ");
            EndContext();
            BeginContext(168, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a3d8773cce0f7fc8988862bf1d9375a966769f94677", async() => {
                BeginContext(268, 77, true);
                WriteLiteral("\r\n        <button type=\"button\" class=\"btn btn-secondary\">Novo</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(349, 127, true);
            WriteLiteral("\r\n</div>\r\n\r\n<table class=\"table table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(477, 40, false);
#line 19 "C:\Dev\fun-com\Views\produto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(517, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(573, 40, false);
#line 22 "C:\Dev\fun-com\Views\produto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(613, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(669, 41, false);
#line 25 "C:\Dev\fun-com\Views\produto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Local));

#line default
#line hidden
            EndContext();
            BeginContext(710, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(766, 41, false);
#line 28 "C:\Dev\fun-com\Views\produto\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(807, 111, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Ação\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n\r\n");
            EndContext();
#line 36 "C:\Dev\fun-com\Views\produto\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(950, 61, true);
            WriteLiteral("    <tbody>\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1012, 39, false);
#line 40 "C:\Dev\fun-com\Views\produto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1107, 39, false);
#line 43 "C:\Dev\fun-com\Views\produto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1202, 40, false);
#line 46 "C:\Dev\fun-com\Views\produto\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Local));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 48 "C:\Dev\fun-com\Views\produto\Index.cshtml"
             if (item.Promo == true)
            {

#line default
#line hidden
            BeginContext(1316, 62, true);
            WriteLiteral("                <td style=\"color: red;\">\r\n                    ");
            EndContext();
            BeginContext(1379, 40, false);
#line 51 "C:\Dev\fun-com\Views\produto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 34, true);
            WriteLiteral(" | #Promo\r\n                </td>\r\n");
            EndContext();
#line 53 "C:\Dev\fun-com\Views\produto\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1501, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1544, 40, false);
#line 57 "C:\Dev\fun-com\Views\produto\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1584, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 59 "C:\Dev\fun-com\Views\produto\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1624, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1659, 58, false);
#line 61 "C:\Dev\fun-com\Views\produto\Index.cshtml"
           Write(Html.ActionLink("Excluir", "delete", new { Id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1738, 57, false);
#line 62 "C:\Dev\fun-com\Views\produto\Index.cshtml"
           Write(Html.ActionLink("Editar", "update", new { Id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 50, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n");
            EndContext();
#line 66 "C:\Dev\fun-com\Views\produto\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1848, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<fun_com.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
