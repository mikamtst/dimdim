#pragma checksum "C:\Users\bsi93328\source\repos\Fiap.DimDim\Fiap.DimDim\Views\Ted\Transferencia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0077afc0408ebf1a4bd69a37b1e9042a09e7d94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ted_Transferencia), @"mvc.1.0.view", @"/Views/Ted/Transferencia.cshtml")]
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
#line 1 "C:\Users\bsi93328\source\repos\Fiap.DimDim\Fiap.DimDim\Views\_ViewImports.cshtml"
using Fiap.DimDim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bsi93328\source\repos\Fiap.DimDim\Fiap.DimDim\Views\_ViewImports.cshtml"
using Fiap.DimDim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0077afc0408ebf1a4bd69a37b1e9042a09e7d94", @"/Views/Ted/Transferencia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098522085b3379577cb03866be9e1c821c5f5351", @"/Views/_ViewImports.cshtml")]
    public class Views_Ted_Transferencia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\bsi93328\source\repos\Fiap.DimDim\Fiap.DimDim\Views\Ted\Transferencia.cshtml"
  
    ViewData["Title"] = "Transferencia";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Transferencia</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0077afc0408ebf1a4bd69a37b1e9042a09e7d943823", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"valor\"");
                BeginWriteAttribute("value", " value=\"", 136, "\"", 144, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control mt-4\" placeholder=\"Valor\" />\r\n    <input type=\"text\" name=\"nomebanco\"");
                BeginWriteAttribute("value", " value=\"", 235, "\"", 243, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control mt-4\" placeholder=\"Nome Banco\" />\r\n    <input type=\"text\" name=\"favorecidoagencia\"");
                BeginWriteAttribute("value", " value=\"", 347, "\"", 355, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control mt-4\" placeholder=\"Favorecido Agencia\" />\r\n    <input type=\"text\" name=\"favorecidoconta\"");
                BeginWriteAttribute("value", " value=\"", 465, "\"", 473, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control mt-4\" placeholder=\"Favorecido Conta\" />\r\n    <input type=\"text\" name=\"favorecidonome\"");
                BeginWriteAttribute("value", " value=\"", 580, "\"", 588, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control mt-4\" placeholder=\"Favorecido Nome\" />\r\n    <input type=\"text\" name=\"favorecidodocumento\"");
                BeginWriteAttribute("value", " value=\"", 699, "\"", 707, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control mt-4\" placeholder=\"Favorecido Documento\" />\r\n    <input type=\"text\" name=\"observacao\"");
                BeginWriteAttribute("value", " value=\"", 814, "\"", 822, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control mt-4"" placeholder=""Observa????o"" />
    <input type=""submit"" value=""Realizar Transferencia"" class=""btn btn-lg btn-outline-warning btn-block mt-3 mb-2"" />
    <a href=""/Home/Logado"" title=""Logado"" class=""btn btn-lg btn-dark col-md-3"">
        <span class=""glyphicon glyphicon-edit"" aria-hidden=""true""></span>
        Sair
    </a>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
