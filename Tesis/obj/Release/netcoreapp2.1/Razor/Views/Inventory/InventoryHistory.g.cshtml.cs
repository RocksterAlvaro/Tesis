#pragma checksum "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\Inventory\InventoryHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "089e7ebaf5d3aa7efd8ab2bfad8236aa417a910f"
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
#line 1 "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\_ViewImports.cshtml"
using Tesis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089e7ebaf5d3aa7efd8ab2bfad8236aa417a910f", @"/Views/Inventory/InventoryHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b8230867da10110ca3d56b2c2fbb3a8e440d01", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_InventoryHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\Inventory\InventoryHistory.cshtml"
  
    ViewData["Title"] = "InventoryHistory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(101, 3624, true);
            WriteLiteral(@"
<div class=""container anythingElseContent"">
    <br />

    <h1> Historial de movimientos </h1>

    <div class=""form-row"">
        <div class=""form-group col-md-4"">
            <input id=""SearchBar""
                   oninput=""SearchProduct(this.value)""
                   class=""form-control mr-sm-2 ""
                   type=""search""
                   placeholder=""Buscar productos""
                   aria-label=""Search"">
        </div>
        <div class=""form-group col-md-1"">
            <button class=""btn btn-success my-2 my-sm-0"" type=""submit"">Buscar</button>
        </div>


        <div class=""form-group col-md-3 offset-4"">

            <a class=""btn btn-success"" href=""/Inventory/InventoryMain"" style=""margin-left:53%"">Mov Inventario</a>
        </div>

    </div>
    <br /><br />
    <table class=""table tableHeader"">
        <thead>
            <tr>
                <th scope=""col"" style=""width:215px""># Movimiento</th>
                <th scope=""col"" style=""width:180px"">F");
            WriteLiteral(@"echa</th>
                <th scope=""col"" style=""width:170px"">Valor total</th>
                <th scope=""col"" style=""width:220px"">Venta/Traslado</th>
                <th scope=""col"">Entrada/Salida</th>
                <th scope=""col"" style=""width:20px""></th>
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
        <div class=""modal-content");
            WriteLiteral(@""">
            <div class=""modal-header"">
                <h3 class=""modal-title"" id=""ModalTitle"">Detalles del traslado</h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
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
                                <tr id="""">");
            WriteLiteral(@"
                                    <th scope=""row"" style=""min-width:75px;max-width:75px"">Hyperdimension neptunia re:birth 3 V Century</th>
                                    <td>100000</td>
                                </tr>   
                            </tbody>
                        </table>
                    </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>");
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