#pragma checksum "C:\Users\Saito\Desktop\TesisNoire\AzureNoire\Tesis-master\Tesis\Views\Products\ProductsMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d497e363f8c48f0903c7a3bbfbdeabc148034bd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tesis.Pages.Products.Views_Products_ProductsMain), @"mvc.1.0.view", @"/Views/Products/ProductsMain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/ProductsMain.cshtml", typeof(Tesis.Pages.Products.Views_Products_ProductsMain))]
namespace Tesis.Pages.Products
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d497e363f8c48f0903c7a3bbfbdeabc148034bd0", @"/Views/Products/ProductsMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7779f30505031de33ee38516f83bb1b07bd4c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ProductsMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/search.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ProductForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Saito\Desktop\TesisNoire\AzureNoire\Tesis-master\Tesis\Views\Products\ProductsMain.cshtml"
  
    ViewData["Title"] = "Products";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 346, true);
            WriteLiteral(@"
    <div class=""container anythingElseContent"">
        <br />
        <h1> Productos </h1>
        <div class=""form-row"">
            <div class=""form-group col-md-7"">
                <div class=""inner-form"">
                    <div class=""input-field first-wrap"">
                        <div class=""svg-wrapper"">
                            ");
            EndContext();
            BeginContext(433, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5b695f428ada466ea8d9ff32acdfdfd4", async() => {
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
            BeginContext(493, 2984, true);
            WriteLiteral(@"
                        </div>
                        <input id=""SearchBar""
                               oninput=""SearchProduct(this.value)""
                               class=""col-md-10""
                               type=""search""
                               placeholder=""Buscar productos""
                               aria-label=""Search"">
                    </div>
                </div>
            </div>


            <div class=""form-group col-md-3 offset-2"">
                <button onclick=""OpenProductModal('CreateProductModal', -1)""
                        type=""button""
                        class=""btn btn-primary""
                        data-toggle=""modal""
                        data-target=""#ProductModal"">
                    Nuevo Producto
                </button>
                <a class=""btn btn-success"" href=""/Inventory/InventoryMain"">Mov Inventario</a>
            </div>



        </div>
        <!--
    <div class=""form-row"">

        <div class=""form-group offset-9 col-md-3"">
 ");
            WriteLiteral(@"           <select id=""userType"" class=""form-control"" style="" font-weight:bolder;"">
                <option selected>Ver productos Activos</option>
                <option>Ver productos Inactivos</option>
                <option>Ver todos los productos</option>
            </select>
        </div>

    </div>
        -->
        <br />
        <table class=""table tableHeader"">
            <thead>
                <tr>
                    <th scope=""col"" style=""width:112px""> Producto </th>
                    <th scope=""col"" style=""width:95px""> Precio </th>
                    <th scope=""col"" style=""width:50px""> Unidades </th>
                    <th scope=""col"" style=""width:80px""> Costo de pedido </th>
                    <th scope=""col"" style=""width:50px"">  </th>
                    <th scope=""col"" style=""width:50px"">  </th>
                </tr>
            </thead>
        </table>
        <div class=""responsiveScrollProducts"">
            <table class=""table"">
                <tbody id=""SearchProducts"">
  ");
            WriteLiteral(@"                  <tr id=""ProductList"">
                        <th scope=""row"" style=""height:43vh; text-align:justify;"">
                        <td colspan=""3"">Ninguna busqueda realizada</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>


<!-- Product Modal -->
<div class=""modal fade"" id=""ProductModal"" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"" id=""ModalTitle""></h3>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div class=""modal-body"">

                ");
            EndContext();
            BeginContext(3477, 2697, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cfc07098cdb4525987d52f52f296c89", async() => {
                BeginContext(3514, 2653, true);
                WriteLiteral(@"

                    <div class=""form-row"">
                        <div class=""form-group col-md-8 offset-2"">
                            <label for=""ProductName"">Nombre del producto</label>
                            <input type=""text""
                                   class=""form-control""
                                   id=""ProductName""
                                   name=""ProductName""
                                   placeholder=""Nombre del producto""
                                   required>
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-4 center-block offset-2"">
                            <label for=""ProductPrice"">Precio</label>
                            <input type=""number""
                                   class=""form-control""
                                   id=""ProductPrice""
                                   name=""ProductPrice""
                                   placeholde");
                WriteLiteral(@"r=""Precio del producto""
                                   required>
                        </div>
                        <div class=""form-group col-md-4 center-block"">
                            <label for=""ProductCost"">Costo de pedido</label>
                            <input type=""number""
                                   class=""form-control""
                                   id=""ProductCost""
                                   name=""ProductCost""
                                   placeholder=""Costo de pedido""
                                   required>
                        </div>

                    </div>
                    <div class=""form-row"">

                        <div class=""form-group col-md-8 center-block offset-2"">
                            <label id=""ProductStockTitle"" for=""ProductStock"">Inventario inicial</label>
                            <input type=""number""
                                   class=""form-control""
                                   id=""ProductStock""
          ");
                WriteLiteral(@"                         name=""ProductStock""
                                   placeholder=""Unidades iniciales del producto""
                                   required>
                        </div>

                    </div>
                    <hr />

                    <input type=""hidden"" id=""ProductId"" name=""ProductId"" value="""" />

                    <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"" style=""margin-left:380px"">Cerrar</button>
                    <button id=""SuccessModalButton"" type=""submit"" class=""btn btn-outline-success""></button>

                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6174, 53, true);
            WriteLiteral("\n\n            </div>\n        </div>\n    </div>\n</div>");
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
