#pragma checksum "C:\Dev\fun-com\Views\Produto\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3adb5646dbeed32418078b5763cd858271e9b061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Create), @"mvc.1.0.view", @"/Views/Produto/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Create.cshtml", typeof(AspNetCore.Views_Produto_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3adb5646dbeed32418078b5763cd858271e9b061", @"/Views/Produto/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c038c370c853bf23840d64eefff98a6678891498", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<fun_com.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(68, 23, false);
#line 5 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(95, 85, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Produto</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(181, 64, false);
#line 10 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(245, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(294, 93, false);
#line 12 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(387, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(443, 93, false);
#line 14 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(536, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(555, 82, false);
#line 15 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(637, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(724, 93, false);
#line 20 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
       Write(Html.LabelFor(model => model.Tipo, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(817, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(873, 93, false);
#line 22 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
           Write(Html.EditorFor(model => model.Tipo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(966, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(985, 82, false);
#line 23 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Tipo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1154, 94, false);
#line 28 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
       Write(Html.LabelFor(model => model.Local, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1304, 94, false);
#line 30 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
           Write(Html.EditorFor(model => model.Local, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1417, 83, false);
#line 31 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Local, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1587, 94, false);
#line 36 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
       Write(Html.LabelFor(model => model.Valor, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1737, 94, false);
#line 38 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
           Write(Html.EditorFor(model => model.Valor, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1850, 83, false);
#line 39 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Valor, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 255, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 49 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
}

#line default
#line hidden
            BeginContext(2191, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2205, 34, false);
#line 52 "C:\Dev\fun-com\Views\Produto\Create.cshtml"
Write(Html.ActionLink("Voltar", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2239, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<fun_com.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
