#pragma checksum "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\Inventory\InventoryAI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d1156e4c1c50249e494384df035caf3450c7086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tesis.Pages.Inventory.Views_Inventory_InventoryAI), @"mvc.1.0.view", @"/Views/Inventory/InventoryAI.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/InventoryAI.cshtml", typeof(Tesis.Pages.Inventory.Views_Inventory_InventoryAI))]
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
#line 1 "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\_ViewImports.cshtml"
using Tesis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1156e4c1c50249e494384df035caf3450c7086", @"/Views/Inventory/InventoryAI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b8230867da10110ca3d56b2c2fbb3a8e440d01", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_InventoryAI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\Inventory\InventoryAI.cshtml"
  
    ViewData["Title"] = "InventoryAI";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(96, 302, true);
            WriteLiteral(@"
<div class=""container anythingElseContent"">
    <br />
    <h1>Predictor de inventario</h1>

    <br />

    <div class=""form-row"">

        <div class=""input-group col-md-8"">
            <div class=""input-group-prepend"">
                <div class=""input-group-text"">
                    ");
            EndContext();
            BeginContext(398, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fb6b0fb10bf54fb0a8cd8942fa0e2e38", async() => {
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
            BeginContext(458, 5430, true);
            WriteLiteral(@"
                </div>
            </div>
            <input id=""SearchBar""
                   oninput=""SearchProduct(this.value)""
                   class=""form-control mr-sm-2 ""
                   type=""search""
                   placeholder=""Buscar productos""
                   aria-label=""Search"">
        </div>
    </div>

    <br />
    <br />

    <div class=""form-row"">

        <!--Left table-->
        <div class=""form-group col-md-6 "">
            <h4>Productos</h4>
            <table class=""table tableHeader"">
                <thead>
                    <tr>
                        <th scope=""col"">Producto</th>
                        <th scope=""col"" class=""text-center"">Precio</th>
                        <th scope=""col"" class=""text-center"">Unidades</th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
            </table>
            <div class=""responsiveScroll"">
                <table class=""table"">
                ");
            WriteLiteral(@"    <tbody id=""SearchProducts"">
                        <tr id=""ProductList"">
                            <th scope=""row"" style=""height:43vh; text-align:justify;"">
                            <td colspan=""3"">Ninguna busqueda realizada</td>
                        </tr>

                    </tbody>
                </table>

            </div>


        </div>


        <!--Right table-->
        <div class=""form-group col-md-6"">
            <h4>Productos a predecir</h4>
            <table class=""table tableHeader"">
                <thead>
                    <tr>
                        <th scope=""col"">Producto</th>
                        <th scope=""col"" class=""text-center""> Unidades predecidas </th>
                        <th scope=""col"" class=""text-center""> Precio predecido</th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
            </table>
            <div class=""responsiveScroll"">
                <table class=""table"">
");
            WriteLiteral(@"
                    <tbody id=""MovementProducts"">
                        <tr>
                            <th scope=""row"" style=""height:43vh"">
                            <td colspan=""3"">No se ha añadido ningún producto</td>
                        </tr>

                    </tbody>
                </table>

            </div>


        </div>

        <!--Save and 0 inventory buttons-->

        <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
            <button type=""button"" class=""btn btn-outline-info"">Agregar todos </button>
            <button type=""button"" class=""btn btn-outline-danger"">Quitar todos</button>
        </div>
        <button type=""button"" class=""btn btn-outline-success"" onclick=""PredictProducts()"" style=""margin-left:82vh;"">Predecir</button>
    </div>

    <!-- Predict Products Modal -->
    <div class=""modal fade bd-example-modal-lg"" id=""PredictProductsModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog modal-");
            WriteLiteral(@"dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle""> Productos Predecidos </h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <table class=""table tableHeader"">
                        <thead>
                            <tr>
                                <th scope=""col"" style=""min-width:110px;max-width:110px""> Producto </th>
                                <th scope=""col"" style=""min-width:110px;max-width:110px""> Unidades Predecidas </th>
                                <th scope=""col"" style=""min-width:110px;max-width:110px""> Mes Predecido </th>
                            </tr>
                        </thead>
                    </");
            WriteLiteral(@"table>
                    <div class=""responsiveScrollProducts"">
                        <table class=""table"">
                            <tbody id=""PredictProductsTableBody"">
                                <!-- Product Predicted Name -->
                                <!-- Product Predicted Value -->
                                <!-- Product Predicted Date -->
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button data-dismiss=""modal"" class=""btn btn-outline-success my-2 my-sm-0""> Ok </button>
                </div>
            </div>
        </div>
    </div>

    <!-- Invalid Values Modal -->
    <div id=""InvalidValuesModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <button onclick=""CloseModal()""> x </button>

            <span class=""close"">x</span>

            <p>
                Algu");
            WriteLiteral(@"no de los valores ingresados es invalido.
                <br>
                Por favor verifique los valores.
            </p>

            <button onclick=""CloseModal()"" class=""btn btn-outline-success my-2 my-sm-0""> Entendido </button>

        </div>
    </div>
</div>

<script>



</script>");
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
