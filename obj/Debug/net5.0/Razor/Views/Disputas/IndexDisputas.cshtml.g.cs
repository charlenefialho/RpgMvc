#pragma checksum "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b60c80fee15025ace73ef7078c20d632287706d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disputas_IndexDisputas), @"mvc.1.0.view", @"/Views/Disputas/IndexDisputas.cshtml")]
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
#line 1 "F:\DS\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DS\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b60c80fee15025ace73ef7078c20d632287706d", @"/Views/Disputas/IndexDisputas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Disputas_IndexDisputas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RpgMvc.Models.DisputaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 6 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
   Write(Html.Raw(@TempData["Mensagem"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 13 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
   Write(Html.Raw(@TempData["MensagemErro"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 15 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
  ViewBag.Title = "Disputas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Titulo da pagina para o navegador -->\r\n<h2>Relação de Disputas</h2><!-- titulo da pagina-->\r\n<table class=\"table\">\r\n    <tr><!--Titulos das colunas da tabela-->\r\n        <th>");
#nullable restore
#line 21 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 22 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
       Write(Html.DisplayNameFor(model => model.DataDisputa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 23 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
       Write(Html.DisplayNameFor(model => model.Narracao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 24 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
       Write(Html.DisplayNameFor(model => model.Resultados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n    <!--Looping para escrever os dados na tabela -->\r\n");
#nullable restore
#line 28 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 31 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataDisputa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Narracao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Resultados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 38 "F:\DS\RpgMvc\Views\Disputas\IndexDisputas.cshtml"
Write(Html.ActionLink("Apagar Disputas", "ApagarDisputas", "Disputas", null
    ,new{@class = "btn btn-danger", onclick = "returnconfirm('Deseja realmente deletar este personagem?);"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RpgMvc.Models.DisputaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591