#pragma checksum "C:\Users\Saito\Desktop\TesisNoire\TesisGit\Tesis\Views\Login\SigninMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c47f786fc33c15f20304b022a735995d027b85f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tesis.Pages.Login.Views_Login_SigninMain), @"mvc.1.0.view", @"/Views/Login/SigninMain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/SigninMain.cshtml", typeof(Tesis.Pages.Login.Views_Login_SigninMain))]
namespace Tesis.Pages.Login
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Saito\Desktop\TesisNoire\TesisGit\Tesis\Views\_ViewImports.cshtml"
using Tesis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c47f786fc33c15f20304b022a735995d027b85f2", @"/Views/Login/SigninMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b8230867da10110ca3d56b2c2fbb3a8e440d01", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_SigninMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Saito\Desktop\TesisNoire\TesisGit\Tesis\Views\Login\SigninMain.cshtml"
  
    ViewData["Title"] = "Signin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 205, true);
            WriteLiteral("}\r\n\r\n\r\n\r\n\r\n<div class=\"container\">\r\n    <!--Luego mejoro esta cosa fea-->\r\n    <br /><br /><br /><br />\r\n    <div class=\"text-center\">\r\n        <h1>Registrate</h1>\r\n        <br /><br />\r\n    </div>\r\n\r\n    ");
            EndContext();
            BeginContext(296, 2783, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c0e3dfde4f647fd8e0ede57463f43b6", async() => {
                BeginContext(302, 2125, true);
                WriteLiteral(@"

        <div class=""form-row"">
            <div class=""form-group col-md-4"">
            </div>

            <div class=""form-group col-md-2"">
                <label for=""name"">Nombre</label>
                <input type=""text"" class=""form-control"" id=""name"" placeholder=""Nombre"">
            </div>
            <div class=""form-group col-md-2"">
                <label for=""lastName"">Apellido</label>
                <input type=""text"" class=""form-control"" id=""lastName"" placeholder=""Apellido"">
            </div>

        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-4 center-block"">

            </div>
            <div class=""form-group col-md-4 center-block"">
                <label for=""id"">Cedula</label>
                <input type=""number"" class=""form-control"" id=""id"" placeholder=""Cedula"">
            </div>

        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-4 center-block"">

            </div>
            <d");
                WriteLiteral(@"iv class=""form-group col-md-4 center-block"">
                <label for=""user"">Usuario</label>
                <input type=""text"" class=""form-control"" id=""user"" placeholder=""Usuario"">
            </div>

        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-4"">
            </div>

            <div class=""form-group col-md-2"">
                <label for=""password"">Contraseña</label>
                <input type=""password"" class=""form-control"" id=""password"" placeholder=""Contraseña"">
            </div>
            <div class=""form-group col-md-2"">
                <label for=""password"">Confirmar contraseña</label>
                <input type=""password"" class=""form-control"" id=""password"" placeholder=""Constraseña"">
            </div>

        </div>

        <div class=""form-row"">
            <div class=""form-group col-md-4"">

            </div>
            <div class=""form-group col-md-4"">
                <label for=""userType"">Tipo de usuario</label>
    ");
                WriteLiteral("            <select id=\"userType\" class=\"form-control\">\r\n                    ");
                EndContext();
                BeginContext(2427, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9e1c1022194698a561bc952629942e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2453, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2475, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7fa19aae8e44d97a84c39285939eaee", async() => {
                    BeginContext(2483, 8, true);
                    WriteLiteral("Vendedor");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2500, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2522, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f245bf7e3e1241168677e8ecdc12b556", async() => {
                    BeginContext(2530, 13, true);
                    WriteLiteral("Administrador");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2552, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2574, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37531ee86923496cb6088c25b8419c30", async() => {
                    BeginContext(2582, 5, true);
                    WriteLiteral("Otros");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2596, 476, true);
                WriteLiteral(@"
                </select>
            </div>

        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-5"">

            </div>
            <div class=""form-group col-md-1"">
                <a href=""/index"" class=""btn btn-danger"">Cancelar</a>
            </div>
            <div class=""form-group col-md-1"">
                <button type=""submit"" class=""btn btn-primary"">Registrarse</button>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3079, 71, true);
            WriteLiteral("\r\n</div>\r\n<!--Y esta tambien-->\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
