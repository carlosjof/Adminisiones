#pragma checksum "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6339ea2af78d2918c62e2fcebf8a675281e21a64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PerfilUsuarios_Details), @"mvc.1.0.view", @"/Views/PerfilUsuarios/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PerfilUsuarios/Details.cshtml", typeof(AspNetCore.Views_PerfilUsuarios_Details))]
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
#line 1 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\_ViewImports.cshtml"
using Admisiones;

#line default
#line hidden
#line 2 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\_ViewImports.cshtml"
using Admisiones.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6339ea2af78d2918c62e2fcebf8a675281e21a64", @"/Views/PerfilUsuarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"293ed64ae865a123b3480d7f52172a39ba80e3b8", @"/Views/_ViewImports.cshtml")]
    public class Views_PerfilUsuarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admisiones.Models.PerfilUsuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 119, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>PerfilUsuario</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(200, 48, false);
#line 14 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimerNombre));

#line default
#line hidden
            EndContext();
            BeginContext(248, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(289, 44, false);
#line 17 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrimerNombre));

#line default
#line hidden
            EndContext();
            BeginContext(333, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(374, 49, false);
#line 20 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SegundoNombre));

#line default
#line hidden
            EndContext();
            BeginContext(423, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(464, 45, false);
#line 23 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.SegundoNombre));

#line default
#line hidden
            EndContext();
            BeginContext(509, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(550, 50, false);
#line 26 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimerApellido));

#line default
#line hidden
            EndContext();
            BeginContext(600, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(641, 46, false);
#line 29 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrimerApellido));

#line default
#line hidden
            EndContext();
            BeginContext(687, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(728, 51, false);
#line 32 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SegundoApellido));

#line default
#line hidden
            EndContext();
            BeginContext(779, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(820, 47, false);
#line 35 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.SegundoApellido));

#line default
#line hidden
            EndContext();
            BeginContext(867, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(908, 51, false);
#line 38 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(959, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1000, 47, false);
#line 41 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1088, 51, false);
#line 44 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LugarNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1180, 47, false);
#line 47 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.LugarNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1268, 42, false);
#line 50 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1351, 38, false);
#line 53 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1430, 47, false);
#line 56 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1518, 43, false);
#line 59 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1602, 50, false);
#line 62 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CorreoPrimario));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1693, 46, false);
#line 65 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.CorreoPrimario));

#line default
#line hidden
            EndContext();
            BeginContext(1739, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1780, 52, false);
#line 68 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CorreoSecundario));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1873, 48, false);
#line 71 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.CorreoSecundario));

#line default
#line hidden
            EndContext();
            BeginContext(1921, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1962, 54, false);
#line 74 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoIdentificacion));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2057, 50, false);
#line 77 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoIdentificacion));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2148, 56, false);
#line 80 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroIdentificacion));

#line default
#line hidden
            EndContext();
            BeginContext(2204, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2245, 52, false);
#line 83 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumeroIdentificacion));

#line default
#line hidden
            EndContext();
            BeginContext(2297, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2338, 43, false);
#line 86 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2422, 39, false);
#line 89 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(2461, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2502, 52, false);
#line 92 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TelefonoPrimario));

#line default
#line hidden
            EndContext();
            BeginContext(2554, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2595, 48, false);
#line 95 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.TelefonoPrimario));

#line default
#line hidden
            EndContext();
            BeginContext(2643, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2684, 54, false);
#line 98 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TelefonoSecundario));

#line default
#line hidden
            EndContext();
            BeginContext(2738, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2779, 50, false);
#line 101 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.TelefonoSecundario));

#line default
#line hidden
            EndContext();
            BeginContext(2829, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2870, 46, false);
#line 104 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contrasena));

#line default
#line hidden
            EndContext();
            BeginContext(2916, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2957, 42, false);
#line 107 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contrasena));

#line default
#line hidden
            EndContext();
            BeginContext(2999, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(3041, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1db2c2625ccb4fdb83ea36e098c84d20", async() => {
                BeginContext(3100, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\carlos.ozuna\Desktop\Adminisiones-master\Views\PerfilUsuarios\Details.cshtml"
                           WriteLiteral(Model.PerfilusuarioId);

#line default
#line hidden
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
            EndContext();
            BeginContext(3108, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(3115, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e295a943164546e7a844bc48dd327ddd", async() => {
                BeginContext(3137, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3153, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admisiones.Models.PerfilUsuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
