#pragma checksum "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\Products\ProductsMain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8a42c084f4945175d371e1bf685806f549576a"
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
#line 1 "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\_ViewImports.cshtml"
using Tesis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8a42c084f4945175d371e1bf685806f549576a", @"/Views/Products/ProductsMain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b8230867da10110ca3d56b2c2fbb3a8e440d01", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ProductsMain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ProductForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Rockster_Laptop\Desktop\Tesis\Tesis\Views\Products\ProductsMain.cshtml"
  
    ViewData["Title"] = "Products";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 1384, true);
            WriteLiteral(@"
    <div class=""container anythingElseContent"">
        <br />
        <h1> Productos </h1>
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
                <button onclick=""OpenProductModal('CreateProductModal', -1)""
                        type=""button""
                        class=""btn btn-primary""
                        data-toggle=""modal""
                        data-target=""#ProductModal"">
                    Nuevo Producto
                <");
            WriteLiteral(@"/button>
                <a class=""btn btn-success"" href=""/Inventory/InventoryMain"">Mov Inventario</a>
            </div>



        </div>
        <div class=""form-row"">
           
            <div class=""form-group offset-9 col-md-3"">  
                <select id=""userType"" class=""form-control"" style="" font-weight:bolder;"">
                    ");
            EndContext();
            BeginContext(1475, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "362bb72d13304f5d80212a40d9c721ed", async() => {
                BeginContext(1492, 21, true);
                WriteLiteral("Ver productos Activos");
                EndContext();
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
            BeginContext(1522, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1544, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b33fef2db14574af8e8e1f5720ba59", async() => {
                BeginContext(1552, 23, true);
                WriteLiteral("Ver productos Inactivos");
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
            BeginContext(1584, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1606, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1cba0b7f4f4afb807a21677962e82a", async() => {
                BeginContext(1614, 23, true);
                WriteLiteral("Ver todos los productos");
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
            BeginContext(1646, 1743, true);
            WriteLiteral(@"
                </select>
            </div>

        </div>
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
                    <tr id=""ProductList"">
                        <th scope=""row"" style=""height:43vh; text-align:justify;"">
                        <td colspan=""3"">Ninguna busqueda realizada</td>
                    </tr>
                ");
            WriteLiteral(@"</tbody>
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
            BeginContext(3389, 2751, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bd256cc250f484fb2014cc8ff94c4f0", async() => {
                BeginContext(3426, 2707, true);
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
                         ");
                WriteLiteral(@"          placeholder=""Precio del producto""
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
                       ");
                WriteLiteral(@"            id=""ProductStock""
                                   name=""ProductStock""
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6140, 58, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
