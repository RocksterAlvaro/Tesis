#pragma checksum "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Pages\Product\ProductMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdcaff6de9f8681638f566e2b887daf5be1da220"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tesis.Pages.Product.Pages_Product_ProductMain), @"mvc.1.0.razor-page", @"/Pages/Product/ProductMain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Product/ProductMain.cshtml", typeof(Tesis.Pages.Product.Pages_Product_ProductMain), null)]
namespace Tesis.Pages.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Pages\_ViewImports.cshtml"
using Tesis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdcaff6de9f8681638f566e2b887daf5be1da220", @"/Pages/Product/ProductMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b8230867da10110ca3d56b2c2fbb3a8e440d01", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product_ProductMain : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Pages\Product\ProductMain.cshtml"
  
    ViewData["Title"] = "Productos";

#line default
#line hidden
            BeginContext(52, 1965, true);
            WriteLiteral(@"
<div class=""container"">
    <br />
    <h1> Productos </h1>
    <div class=""form-row"">
        <div class=""form-group col-md-4"">
            <input id=""SearchBar"" class=""form-control mr-sm-2 "" type=""search"" placeholder=""Buscar"" aria-label=""Search"">
        </div>
        <div class=""form-group col-md-1"">
            <button class=""btn btn-success my-2 my-sm-0"" type=""submit"">Buscar</button>
        </div>


        <div class=""form-group col-md-3 offset-4"">
            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#createProduct"">Nuevo Producto</button>
            <a class=""btn btn-success"" href=""/Inventory/InventoryMain"">Mov Inventario</a>
        </div>



    </div>
    <br /><br />

    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Codigo</th>
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Precio</th>
                <th scope=""col"">Cantidad</th>
                <th scope=""");
            WriteLiteral(@"col""></th>
                <th scope=""col"" style=""color:red""></th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody id=""SearchProducts"">
            <tr id=""ProductList""></tr>
        </tbody>
    </table>
</div>


<!-- Modal -->
<div class=""modal fade"" id=""createProduct"" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""staticBackdropLabel"">Crear Producto</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>



            <div class=""modal-body"">

                ");
            EndContext();
            BeginContext(2017, 1463, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b5bdb08608141f68c91f559a251f7d8", async() => {
                BeginContext(2023, 1450, true);
                WriteLiteral(@"

                    <div class=""form-row"">
                        <div class=""form-group col-md-8 offset-2"">
                            <label for=""name"">Nombre del producto</label>
                            <input type=""text"" class=""form-control"" id=""Pname"" placeholder=""Nombre del producto"">
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-4 center-block offset-2"">
                            <label for=""id"">Precio</label>
                            <input type=""number"" class=""form-control"" id=""Pprice"" placeholder=""Precio del producto"">
                        </div>
                        <div class=""form-group col-md-4 center-block"">
                            <label for=""id"">Costo de pedido</label>
                            <input type=""number"" class=""form-control"" id=""Pcostk"" placeholder=""Costo por ordenar el producto"">
                        </div>

                    ");
                WriteLiteral(@"</div>
                    <div class=""form-row"">

                        <div class=""form-group col-md-8 center-block offset-2"">
                            <label for=""user"">Stock inicial</label>
                            <input type=""number"" class=""form-control"" id=""Pstock"" placeholder=""Numero de unidades iniciales del producto"">
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
            BeginContext(3480, 1458, true);
            WriteLiteral(@"

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Cerrar</button>
                <button type=""button"" class=""btn btn-outline-success"">Crear</button>
            </div>
        </div>
    </div>
</div>


<!--Searcher-->
<script>

    $('#SearchBar').on('input', function () {
        $.ajax({
            type: ""GET"",
            url: ""/Products/SearchProduct"",
            dataType: ""json"",
            data: {
                SearchString: $(this).val()
            },
            contentType: 'application/json; charset=utf-8',
            //Here I'm
            success: function (response) {

                $(SearchProducts).empty();

                for (var i = 0; i < response.length; i++) {
                    $(""<tr >"" + "" <th scope=\""row\"">"" + response[i].Id + ""</th>"" +
                        ""<td>"" + response[i].productName + ""</td>"" +
                        ""<td>"" + resp");
            WriteLiteral(@"onse[i].productPrice + ""</td>"" +
                        ""<td>"" + response[i].productStock + ""</td>"" +
                        ""<td style=\""color:red\"">Detalles</td>"" +
                        ""<td style=\""color:red\"">Modificar</td>"" +
                        ""<td style=\""color:red\"">Eliminar</td>"" +
                        ""</tr>"").appendTo(SearchProducts);
                }
            }
        });
    });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Product_ProductMain> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Product_ProductMain> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Product_ProductMain>)PageContext?.ViewData;
        public Pages_Product_ProductMain Model => ViewData.Model;
    }
}
#pragma warning restore 1591
