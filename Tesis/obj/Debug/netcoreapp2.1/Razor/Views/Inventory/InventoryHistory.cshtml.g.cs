#pragma checksum "C:\Users\Saito\Desktop\TesisNoire\AzureNoire\Tesis-master\Tesis\Views\Inventory\InventoryHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33321944ee8fcc245633578ffe15c9eaaed29f88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tesis.Pages.Inventory.Views_Inventory_InventoryHistory), @"mvc.1.0.view", @"/Views/Inventory/InventoryHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/InventoryHistory.cshtml", typeof(Tesis.Pages.Inventory.Views_Inventory_InventoryHistory))]
namespace Tesis.Pages.Inventory
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Saito\Desktop\TesisNoire\AzureNoire\Tesis-master\Tesis\Views\_ViewImports.cshtml"
using Tesis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33321944ee8fcc245633578ffe15c9eaaed29f88", @"/Views/Inventory/InventoryHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7779f30505031de33ee38516f83bb1b07bd4c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_InventoryHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/search.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Saito\Desktop\TesisNoire\AzureNoire\Tesis-master\Tesis\Views\Inventory\InventoryHistory.cshtml"
  
    ViewData["Title"] = "InventoryHistory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(96, 327, true);
            WriteLiteral(@"
<div class=""container anythingElseContent"">
    <br />

    <h1> Historial de movimientos </h1>

    <div class=""form-row"">
        <div class=""form-group col-md-7"">
            <div class=""inner-form"">
                <div class=""input-field first-wrap"">
                    <div class=""svg-wrapper"">
                        ");
            EndContext();
            BeginContext(423, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af5a5160259848829b980aa8d6bcb8f8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(483, 3321, true);
            WriteLiteral(@"
                    </div>
                    <input id=""SearchBar""
                           oninput=""SearchProduct(this.value)""
                           class=""col-md-10""
                           type=""search""
                           placeholder=""Buscar movimientos""
                           aria-label=""Search"">
                </div>
            </div>
        </div>
        


        <div class=""form-group col-md-3 offset-2"">

            <a class=""btn btn-success"" href=""/Inventory/InventoryMain"" style=""margin-left:53%"">Mov Inventario</a>
        </div>

    </div>
    <table class=""table tableHeader"">
        <thead>
            <tr>
                <th scope=""col"" style=""width:215px""># Movimiento</th>
                <th scope=""col"" style=""width:180px"">Fecha</th>
                <th scope=""col"" style=""width:170px"">Valor total</th>
                <th scope=""col"" style=""width:220px"">Venta/Traslado</th>
                <th scope=""col"">Entrada/Salida</th>
                <th scope=""col"" style=""");
            WriteLiteral(@"width:20px""></th>
            </tr>
        </thead>
    </table>
    <div class=""responsiveScrollProducts"">
        <table class=""table"">
            <tbody id=""StockInOutList"">
                <tr>
                    <td colspan=""6""> Sin facturas recientes </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>

<!-- Load latest entries of stock in out -->
<script type=""text/javascript"">
    GetLatestStockInOut();
</script>

<!-- Details Modal -->
<div class=""modal fade"" id=""DetailsStockInOutModal"" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"" id=""ModalTitle"">Detalles del traslado</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times");
            WriteLiteral(@";</span>
                </button>
            </div>

            <div class=""modal-body"">
                
                    <table class=""table tableHeader"">
                        <thead>
                            <tr>
                                <th scope=""col""style=""min-width:110px;max-width:110px"">Producto</th>
                                <th scope=""col""style=""min-width:110px;max-width:110px"">Unidades</th>
                            </tr>
                        </thead>
                        </table>
                    <div class=""responsiveScrollProducts"">
                        <table class=""table"">
                            <tbody id=""MovementDetails"">
                                <tr id="""">
                                    <th scope=""row"" style=""min-width:75px;max-width:75px"">Hyperdimension neptunia re:birth 3 V Century</th>
                                    <td>100000</td>
                                </tr>   
                            </tbody>
                   ");
            WriteLiteral("     </table>\n                    </div>\n            </div>\n            <div class=\"modal-footer\">\n                <button type=\"button\" class=\"btn btn-primary\" data-dismiss=\"modal\">Cerrar</button>\n            </div>\n        </div>\n    </div>\n</div>");
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