#pragma checksum "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9d8a939d1732eb559b917c6b30cf1a598063ab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PerfilUsuarios_Delete), @"mvc.1.0.view", @"/Views/PerfilUsuarios/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PerfilUsuarios/Delete.cshtml", typeof(AspNetCore.Views_PerfilUsuarios_Delete))]
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
#line 1 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\_ViewImports.cshtml"
using Admisiones;

#line default
#line hidden
#line 2 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\_ViewImports.cshtml"
using Admisiones.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9d8a939d1732eb559b917c6b30cf1a598063ab7", @"/Views/PerfilUsuarios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f552970267962d228aff345c342f9d71438483", @"/Views/_ViewImports.cshtml")]
    public class Views_PerfilUsuarios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admisiones.Models.PerfilUsuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(84, 174, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>PerfilUsuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(259, 48, false);
#line 15 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimerNombre));

#line default
#line hidden
            EndContext();
            BeginContext(307, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(351, 44, false);
#line 18 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrimerNombre));

#line default
#line hidden
            EndContext();
            BeginContext(395, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(439, 49, false);
#line 21 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SegundoNombre));

#line default
#line hidden
            EndContext();
            BeginContext(488, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(532, 45, false);
#line 24 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SegundoNombre));

#line default
#line hidden
            EndContext();
            BeginContext(577, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(621, 50, false);
#line 27 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimerApellido));

#line default
#line hidden
            EndContext();
            BeginContext(671, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(715, 46, false);
#line 30 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrimerApellido));

#line default
#line hidden
            EndContext();
            BeginContext(761, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(805, 51, false);
#line 33 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SegundoApellido));

#line default
#line hidden
            EndContext();
            BeginContext(856, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(900, 47, false);
#line 36 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SegundoApellido));

#line default
#line hidden
            EndContext();
            BeginContext(947, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(991, 51, false);
#line 39 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1086, 47, false);
#line 42 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1177, 51, false);
#line 45 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LugarNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1272, 47, false);
#line 48 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LugarNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1363, 42, false);
#line 51 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1449, 38, false);
#line 54 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1531, 47, false);
#line 57 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EstadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1622, 43, false);
#line 60 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EstadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1709, 50, false);
#line 63 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CorreoPrimario));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1803, 46, false);
#line 66 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CorreoPrimario));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1893, 52, false);
#line 69 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CorreoSecundario));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1989, 48, false);
#line 72 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CorreoSecundario));

#line default
#line hidden
            EndContext();
            BeginContext(2037, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2081, 54, false);
#line 75 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoIdentificacion));

#line default
#line hidden
            EndContext();
            BeginContext(2135, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2179, 50, false);
#line 78 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TipoIdentificacion));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2273, 56, false);
#line 81 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroIdentificacion));

#line default
#line hidden
            EndContext();
            BeginContext(2329, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2373, 52, false);
#line 84 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumeroIdentificacion));

#line default
#line hidden
            EndContext();
            BeginContext(2425, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2469, 43, false);
#line 87 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(2512, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2556, 39, false);
#line 90 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Celular));

#line default
#line hidden
            EndContext();
            BeginContext(2595, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2639, 52, false);
#line 93 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TelefonoPrimario));

#line default
#line hidden
            EndContext();
            BeginContext(2691, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2735, 48, false);
#line 96 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TelefonoPrimario));

#line default
#line hidden
            EndContext();
            BeginContext(2783, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2827, 54, false);
#line 99 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TelefonoSecundario));

#line default
#line hidden
            EndContext();
            BeginContext(2881, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2925, 50, false);
#line 102 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TelefonoSecundario));

#line default
#line hidden
            EndContext();
            BeginContext(2975, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3019, 46, false);
#line 105 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contrasena));

#line default
#line hidden
            EndContext();
            BeginContext(3065, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3109, 42, false);
#line 108 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contrasena));

#line default
#line hidden
            EndContext();
            BeginContext(3151, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3189, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6153d53f64d14f3d9137044dcd386921", async() => {
                BeginContext(3215, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3225, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1bff057177154493bbd53ef9c67e5aa3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 113 "C:\Users\CarlosJOF\source\repos\Admisiones\Admisiones\Views\PerfilUsuarios\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PerfilusuarioId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3274, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3358, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffea172502fb4ab995077741ad68f56f", async() => {
                    BeginContext(3380, 12, true);
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
                BeginContext(3396, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3409, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admisiones.Models.PerfilUsuario> Html { get; private set; }
    }
}
#pragma warning restore 1591