#pragma checksum "C:\Users\Saito\Desktop\TesisNoire\TesisGit\Tesis\Pages\Login\SigninMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61b09016b791c5d09c370d04f7f313eeae958f8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tesis.Pages.Login.Pages_Login_SigninMain), @"mvc.1.0.razor-page", @"/Pages/Login/SigninMain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Login/SigninMain.cshtml", typeof(Tesis.Pages.Login.Pages_Login_SigninMain), null)]
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
#line 1 "C:\Users\Saito\Desktop\TesisNoire\TesisGit\Tesis\Pages\_ViewImports.cshtml"
using Tesis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b09016b791c5d09c370d04f7f313eeae958f8f", @"/Pages/Login/SigninMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b8230867da10110ca3d56b2c2fbb3a8e440d01", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_SigninMain : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 2 "C:\Users\Saito\Desktop\TesisNoire\TesisGit\Tesis\Pages\Login\SigninMain.cshtml"
  
    ViewData["Title"] = "Signin";

#line default
#line hidden
            BeginContext(49, 230, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"container\">\r\n        <!--Luego mejoro esta cosa fea-->\r\n        <br /><br /><br /><br />\r\n        <div class=\"text-center\">\r\n        <h1>Registrate</h1>\r\n            <br /><br />\r\n        </div>\r\n\r\n        ");
            EndContext();
            BeginContext(279, 3076, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4635212183144976b8e12a8182725a74", async() => {
                BeginContext(285, 2350, true);
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
            <div class=""form-");
                WriteLiteral(@"row"">
                <div class=""form-group col-md-4 center-block"">
                  
                </div>
                <div class=""form-group col-md-4 center-block"">
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

            <div c");
                WriteLiteral(@"lass=""form-row"">
                <div class=""form-group col-md-4"">

                </div>
                <div class=""form-group col-md-4"">
                    <label for=""userType"">Tipo de usuario</label>
                    <select id=""userType"" class=""form-control"">
                        ");
                EndContext();
                BeginContext(2635, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a4258a08e04d9b8baeb5a053f66394", async() => {
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
                BeginContext(2661, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2687, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6181e4a477ef494f9568e39db437d98e", async() => {
                    BeginContext(2695, 8, true);
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
                BeginContext(2712, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2738, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2fcea0991fc404fb37a1a9f8f4b04ea", async() => {
                    BeginContext(2746, 13, true);
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
                BeginContext(2768, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2794, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d59ea9ea2894b5ebf498438d26649ee", async() => {
                    BeginContext(2802, 5, true);
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
                BeginContext(2816, 532, true);
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
            BeginContext(3355, 71, true);
            WriteLiteral("\r\n    </div>\r\n<!--Y esta tambien-->\r\n    <br /><br /><br /><br /><br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Login_SigninMain> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Login_SigninMain> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Login_SigninMain>)PageContext?.ViewData;
        public Pages_Login_SigninMain Model => ViewData.Model;
    }
}
#pragma warning restore 1591
