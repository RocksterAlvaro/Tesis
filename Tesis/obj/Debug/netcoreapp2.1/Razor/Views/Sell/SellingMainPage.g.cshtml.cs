#pragma checksum "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\Sell\SellingMainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "416b802a5db333a7524133a57aa58156329209e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tesis.Pages.Sell.Views_Sell_SellingMainPage), @"mvc.1.0.view", @"/Views/Sell/SellingMainPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sell/SellingMainPage.cshtml", typeof(Tesis.Pages.Sell.Views_Sell_SellingMainPage))]
namespace Tesis.Pages.Sell
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"416b802a5db333a7524133a57aa58156329209e0", @"/Views/Sell/SellingMainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b8230867da10110ca3d56b2c2fbb3a8e440d01", @"/Views/_ViewImports.cshtml")]
    public class Views_Sell_SellingMainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\Sell\SellingMainPage.cshtml"
  
    ViewData["Title"] = "SellMain";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(93, 268, true);
            WriteLiteral(@"

<div class=""anythingElseContent"" style=""margin-left:500px"" >
    <br />
    <div class=""form-row"">

        <div class=""input-group col-md-12"">
            <div class=""input-group-prepend"">
                <div class=""input-group-text"">
                    ");
            EndContext();
            BeginContext(361, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a6c46f1fb3c2452991c84132749b19fe", async() => {
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
            BeginContext(421, 7350, true);
            WriteLiteral(@"
                </div>
            </div>
            <input id=""SearchBar""
                   oninput=""SearchProduct(this.value)""
                   class=""form-control col-md-10""
                   type=""search""
                   placeholder=""Buscar productos""
                   aria-label=""Search"">
        </div>

    </div>

    <br />

    <h4> &nbsp Lista de productos</h4>

    <br />
    <div class=""sellingResponsiveScroll"">
        <div class=""form-row"" id=""SearchProducts"">

            <!-- Search Products -->

        </div>
    </div>

</div>

<script>
    // Update # units without using +/- buttons
    function ChangeUnitsManually(ProductIndex) {
        //Foolish trick to make this no Nep thing works
        var ConcatIdWithRespectiveCode = ""ProductUnits"" + ProductIndex;
        var ConvertToVariable = eval(ConcatIdWithRespectiveCode);
        //console.log(b.value);

        totalUnits2 += (ConvertToVariable.value - totalUnits[ProductIndex]);
        totalU");
            WriteLiteral(@"nits[ProductIndex] = ConvertToVariable.value;

        UpdateLists();
    }
</script>

<!-- Selling Panel -->
<div class=""leftpane"">
    <div class=""order-scroller"">
        <div class=""order"">
            <div class=""orderline"" id=""MovementProducts"">
                <ul>
                    <li id=""OnSaleProducts"" class=""orderline"">
                        <!-- Selling Products -->
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>

<!-- Bottom Panel -->
<div class=""minipane"">
    <div class=""subwindow-container"">
        <div class=""subwindow-container-fix pads"">
            <div class=""container"">
                <br />
                <center><h4>Resumen de la venta</h4></center>
                <span class=""product-name"">Total de la venta</span>
                <span class=""price"" id=""TotalPrice""> 0$ </span>
                <span class=""product-name"">Total de articulos</span>
                <span class=""price"" id=""TotalUnits");
            WriteLiteral(@"""> 0 </span>
                <div class=""justify-content-md-center"">
                    <br />

                    <button type=""button""
                            class=""btn btn-outline-danger totalButtons offset-2""
                            data-toggle=""modal""
                            data-target=""#CancelSellModal"">
                        Cancelar
                    </button>

                    <button type=""button""
                            class=""btn btn-outline-success totalButtons""
                            data-toggle=""modal""
                            data-target=""#ConfirmModal"">
                        Vender
                    </button>
                </div>
            </div>
        </div>
    </div>
</div>

<!--Selling confirmation modal-->
<div class=""modal fade bd-example-modal-lg"" id=""ConfirmModal"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
     ");
            WriteLiteral(@"   <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"" id=""exampleModalLongTitle""> Confirmacion de venta </h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ¿Estas seguro de realizar la venta?
            </div>
            <div class=""modal-footer"">

                <button class=""btn btn-outline-danger my-2 my-sm-0""
                        data-dismiss=""modal""
                        aria-label=""Close"">
                    No
                </button>

                <button onclick=""Sell()""
                        class=""btn btn-outline-success my-2 my-sm-0""
                        data-dismiss=""modal""
                        aria-label=""Close"">
                    Sí
                </button>

            </div>
        </d");
            WriteLiteral(@"iv>
    </div>
</div>

<!--Cancel sell modal-->
<div class=""modal fade bd-example-modal-lg"" id=""CancelSellModal"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"" id=""exampleModalLongTitle""> Cancelar venta </h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ¿Estas seguro que deseas cancelar la venta?, todos los productos en la lista de ventas serán retirados y esta acción no se puede deshacer.
            </div>
            <div class=""modal-footer"">

                <button class=""btn btn-outline-danger my-2 my-sm-0""
                        data-dismiss=""modal""
                ");
            WriteLiteral(@"        aria-label=""Close"">
                    No
                </button>

                <button onclick=""CancelSell()""
                        class=""btn btn-outline-success my-2 my-sm-0""
                        data-dismiss=""modal""
                        aria-label=""Close"">
                    Sí
                </button>

            </div>
        </div>
    </div>
</div>


<!-- Invalid Values Modal -->
<div class=""modal fade bd-example-modal-lg"" id=""InvalidValueModal"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">

    <!-- Modal content -->
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"" id=""exampleModalLongTitle"">Error, datos digitados no validos</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
   ");
            WriteLiteral(@"             </button>
            </div>
            <div class=""modal-body"">
                El valor de unidades digitado en alguno de los productos no es valido, asegurate de que estos valores: <br /><br />
                -Sean numerericos <b>POSITIVOS</b> (1, 2, 30, 60, 1000, etc).<br />
                -No contengan caracteres especiales (-, *, +, !, etc).<br />
                -En el caso de hacer retiro de mercancia, el numero de unidades a sacar debe ser menor o igual al numero de unidades registradas. Por ejemplo, si hay registradas 2 unidades de naranjas solo puede sacar 1 o 2 unidades.<br /><br />
                Además asegurese de que haya por lo menos 1 producto al hacer el traslado de mercancia. En el caso de que no cumpla con alguna de estas restricciones, no podrá hacer el movimiento de inventario.
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-outline-info my-2 my-sm-0"" data-dismiss=""modal"" aria-label=""Close""> Cerrar </button>
  ");
            WriteLiteral("          </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<style>\r\n    .footer {\r\n        display: none;\r\n    }\r\n\r\n    .body-content {\r\n        overflow-x: hidden;\r\n    }\r\n</style>");
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
