#pragma checksum "C:\Dev\fun-com\Views\Produto\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36ef7ef5bd27a195ba222a05c412e2a64a1aa132"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Update), @"mvc.1.0.view", @"/Views/Produto/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Update.cshtml", typeof(AspNetCore.Views_Produto_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ef7ef5bd27a195ba222a05c412e2a64a1aa132", @"/Views/Produto/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c038c370c853bf23840d64eefff98a6678891498", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fun_com.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(68, 23, false);
#line 5 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(95, 95, true);
            WriteLiteral("    <div class=\"form-row mx-auto\" style=\"width: 40%;\">\r\n        <h3>Novo Produto</h3>\r\n        ");
            EndContext();
            BeginContext(191, 64, false);
#line 9 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(255, 63, true);
            WriteLiteral("\r\n        <div class=\"form-group col-md-12 pt-4\">\r\n            ");
            EndContext();
            BeginContext(319, 34, false);
#line 11 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.LabelFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(353, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(368, 93, false);
#line 12 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(461, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(476, 82, false);
#line 13 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(558, 76, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-12\">\r\n            ");
            EndContext();
            BeginContext(635, 34, false);
#line 17 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.LabelFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(669, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(684, 93, false);
#line 18 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.EditorFor(model => model.Tipo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(777, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(792, 82, false);
#line 19 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.ValidationMessageFor(model => model.Tipo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(874, 76, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-12\">\r\n            ");
            EndContext();
            BeginContext(951, 35, false);
#line 23 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.LabelFor(model => model.Local));

#line default
#line hidden
            EndContext();
            BeginContext(986, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1001, 94, false);
#line 24 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.EditorFor(model => model.Local, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1110, 83, false);
#line 25 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.ValidationMessageFor(model => model.Local, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 76, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-12\">\r\n            ");
            EndContext();
            BeginContext(1270, 35, false);
#line 29 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.LabelFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1320, 94, false);
#line 30 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.EditorFor(model => model.Valor, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1429, 83, false);
#line 31 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
       Write(Html.ValidationMessageFor(model => model.Valor, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1512, 180, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group col-md-12 pt-3\">\r\n            <input type=\"submit\" value=\"Salvar\" class=\"btn btn-dark btn-block\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 38 "C:\Dev\fun-com\Views\Produto\Update.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fun_com.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
