#pragma checksum "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09dabf4f3f4ea59095ed6021de3ccf931437ea2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonagemHabilidades_Create), @"mvc.1.0.view", @"/Views/PersonagemHabilidades/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09dabf4f3f4ea59095ed6021de3ccf931437ea2b", @"/Views/PersonagemHabilidades/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonagemHabilidades_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.PersonagemHabilidadeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
    ViewBag.title = "create";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Cadastro de Habilidade para ");
#nullable restore
#line 4 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
                           Write(Model.Personagem.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n\r\n\r\n");
#nullable restore
#line 7 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
 using(Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 13 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
       Write(Html.LabelFor(model => model.Personagem.Id, htmlAttributes: new { @class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 15 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
           Write(Html.EditorFor(model => model.PersonagemId, new {htmlAttributes = new { @class = "form-control", @readonly = "readonly"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class = \"form-group\">\r\n            ");
#nullable restore
#line 19 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
       Write(Html.LabelFor(model => model.Personagem, htmlAttributes: new { @class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 21 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
           Write(Html.EditorFor(model => model.Personagem.Nome, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly"}}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
       Write(Html.LabelFor(model => model.Habilidade, htmlAttributes: new {@class = "control-label col-md-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 27 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
           Write(Html.DropDownListFor(model => model.HabilidadeId, new SelectList(@ViewBag.ListaHabilidades,"Id","Nome"),
                    "---Selecione---", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n             </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-mds-offset-2 col-md-6\">\r\n                <input type=\"submit\" value=\"Salvar\" class=\"btn btn-primary\"/>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n");
#nullable restore
#line 39 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
Write(Html.ActionLink("Retornar ??s habilidades", "Index", "PersonagemHabilidades", new {id = Model.PersonagemId}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
#nullable restore
#line 40 "F:\DS\RpgMvc\Views\PersonagemHabilidades\Create.cshtml"
Write(Html.ActionLink("Retornar aos Personagens", "Index", "Personagens"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.PersonagemHabilidadeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
