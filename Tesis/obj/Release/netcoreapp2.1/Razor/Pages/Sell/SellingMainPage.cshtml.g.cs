#pragma checksum "C:\Users\Saito\Desktop\TesisNoire\TesisGit\Tesis\Pages\Sell\SellingMainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d653f5bba6ed6cc38ee24caa6cf19c69441ecc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Tesis.Pages.Sell.Pages_Sell_SellingMainPage), @"mvc.1.0.razor-page", @"/Pages/Sell/SellingMainPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Sell/SellingMainPage.cshtml", typeof(Tesis.Pages.Sell.Pages_Sell_SellingMainPage), null)]
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
#line 1 "C:\Users\Saito\Desktop\TesisNoire\TesisGit\Tesis\Pages\_ViewImports.cshtml"
using Tesis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d653f5bba6ed6cc38ee24caa6cf19c69441ecc9", @"/Pages/Sell/SellingMainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b8230867da10110ca3d56b2c2fbb3a8e440d01", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Sell_SellingMainPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 2 "C:\Users\Saito\Desktop\TesisNoire\TesisGit\Tesis\Pages\Sell\SellingMainPage.cshtml"
  
    ViewData["Title"] = "Vender";

#line default
#line hidden
            BeginContext(49, 231, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <br />\r\n    <div class=\"form-row\">\r\n\r\n        <div class=\"input-group col-md-12\">\r\n            <div class=\"input-group-prepend\">\r\n                <div class=\"input-group-text\">\r\n                    ");
            EndContext();
            BeginContext(280, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cea917b129b94bad9086209fbac3ef86", async() => {
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
            BeginContext(340, 16601, true);
            WriteLiteral(@"
                </div>
            </div>
            <input id=""SearchBar"" oninput=""SearchProduct(this.value)"" class=""form-control mr-sm-2 "" type=""search"" placeholder=""Buscar productos"" aria-label=""Search"">
        </div>




    </div>
    <h4>Lista de productos</h4>
    <br />

    <div class=""form-row"">

        <div class=""row"" id=""SearchProducts"">
        </div>


    </div>
</div>
<script>

    // Global variables
    var SearchApprovedBool = true;
    var SearchProductsList = [];
    var EditProductsList = [];

    var totalPrice2 = 0;
    var totalUnits2 = 0;
    var totalUnits = [];

    function SearchProduct(SearchWord) {

        // If search is approved by time
        if (SearchApprovedBool) {

            // Clear Search Products List
            $(SearchProducts).empty();

            if (SearchWord.length > 0) {
                // Make the AJAX request
                $.ajax({
                    type: ""GET"",
                    url: ""/Products/Se");
            WriteLiteral(@"archProduct"",
                    dataType: ""json"",
                    data: {
                        SearchString: SearchWord
                    },
                    contentType: 'application/json; charset=utf-8',
                    // If the request is successfull
                    success: function (response) {

                        // Set the products to the global variable
                        SearchProductsList = Array.from(response);
                        //console.log(""Search: "", SearchProductsList);
                        //console.log(""Edit: "", EditProductsList)

                        // Update Lists HTML
                        UpdateLists();

                        // Check if any product was found
                        if (SearchProductsList.length == 0) {
                            // No product returned by the server
                            $(""<li class=\""list-group-item\""> Ningun producto coincide con la busqueda </li>"").appendTo(SearchProducts);
            WriteLiteral(@"
                        }
                    }
                });
            } else {
                // Show the user haven't search anything
                $(""<li class=\""list-group-item\""> Ninguna busqueda realizada </li>"").appendTo(SearchProducts);
            }

            // Deny search
            SearchApproved();
        }
    }

    function AddProductToEditInventory(ProductIndex) {

        // Add the product to the list of editing products
        EditProductsList.push(SearchProductsList[ProductIndex]);

        // Remove the product from the list of searched products
        SearchProductsList.splice(ProductIndex, 1);

        // Update search
        SearchProduct($(SearchBar).val());
    }

    function RemoveProductFromEditInventory(ProductIndex) {

        //Delete a product unit form the total sale
        totalUnits2 -= totalUnits[ProductIndex];

        //Delete total product units
        totalUnits.splice(ProductIndex, 1);

        //Update sale tot");
            WriteLiteral(@"al price
        $(totalPrice).empty();
        $(""<span class=\""price\"" + id=\""totalPrice\"">"" + totalPrice2 + ""$"" +
            ""</span>"").appendTo(totalPrice);

        //Update sale total articles
        $(totalProducts).empty();
        $(""<span class=\""price\"" id=\""totalProducts\""> "" + totalUnits2 + "" Units"" +
            ""</span >"").appendTo(totalProducts);

        // Remove the product from the list of editing products
        EditProductsList.splice(ProductIndex, 1);

        // Clear the list of products searched
        $(EditProducts).empty();

        // Update Lists
        UpdateLists();
    }

    // Increase # units using + button
    function IncreaseSellUnits(ProductIndex) {
        //Increase product units
        totalUnits[ProductIndex]++;

        //Increase total products units
        totalUnits2++;
        UpdateLists();
    }

    // Decrease # units using - button
    function DecreaseSellUnits(ProductIndex) {
        if (totalUnits[ProductIndex] > ");
            WriteLiteral(@"1) {

            //Decrease product units
            totalUnits[ProductIndex]--;

            //Decrease total products units
            totalUnits2--;
            UpdateLists();
        } else if (totalUnits[ProductIndex] == 1) {
            RemoveProductFromEditInventory(ProductIndex);
        }
    }

    // Update # units without using +/- buttons
    function ChangeUnitsManually(ProductIndex) {
        //Foolish trick to make this no Nep thing works
        var ConcatIdWithRespectiveCode = ""ProductUnits"" + ProductIndex;
        var ConvertToVariable = eval(ConcatIdWithRespectiveCode);
        //console.log(b.value);

        totalUnits2 += (ConvertToVariable.value - totalUnits[ProductIndex]);
        totalUnits[ProductIndex] = ConvertToVariable.value;
        //console.log(totalUnits[ProductIndex] + ""Nowa nowa nowa nowa nowa nowa nowa nowa no"");
        UpdateLists();
    }

    // Update Lists
    function UpdateLists() {
        // Clear Search Products List
        $(Se");
            WriteLiteral(@"archProducts).empty();

        // Fill the list with the products returned by the server
        for (var i = 0; i < SearchProductsList.length; i++) {
            // If the Product is not being edit yet
            if (!EditProductsContains(SearchProductsList[i])) {
                //console.log(""2"");
                $(""<div id=\""SearchProduct"" + i + ""\"" class=\""card justify-content-center\""  style=\""width: 12rem;\"">"" +
                    "" <div class=\""card-body\"">"" +
                    ""<h5 class=\""card-title\"">"" + SearchProductsList[i].productName + ""</h5>"" +
                    ""<h6 class=\""card-subtitle mb-2 text-muted\"">"" + SearchProductsList[i].productStock + "" Unidades"" + ""</h6>"" +
                    ""<p class=\""card-text\"">"" + SearchProductsList[i].productPrice + "" $"" + ""</p>"" +
                    ""<button type=\""button\"" onclick=\""AddProductToEditInventory("" + i + "")\"" class=\""btn btn-outline-info\""> Agregar </button>"" +
                    ""</div > "" +
                    ""</div>");
            WriteLiteral(@""").appendTo(SearchProducts);
            }

        }

        // Clear Edit Products List HTML
        $(EditProducts).empty();

        // Update Edit Products List
        for (var i = 0; i < EditProductsList.length; i++) {

            //Initialice items of a new product
            if (totalUnits[i] == null) {
                totalUnits[i] = 1;
                totalUnits2++;
            }

            $(""<li id=\""EditProduct"" + i + ""\""class=\""orderline\"">"" +
                ""<span class=\""product-name\"">"" + EditProductsList[i].productName + ""</span>"" +
                ""<span class=\""price\"">"" + ""$"" + (EditProductsList[i].productPrice * totalUnits[i]) + ""</span>"" +
                ""<ul class=\""info-list\"">"" + ""<div class=\""btn-toolbar mb-4\""> <div class=\""input-group\"">"" +
                ""<input type=\""text\"" onChange=\""ChangeUnitsManually("" + i + "")\"" id=\""ProductUnits"" + i + ""\"" value="" + totalUnits[i] + "" class=\""form-control\"" style=\""width: 60px; height: 22px; \""> <div class=\""i");
            WriteLiteral(@"nput-group-prepend\""> <div class=\""input-group-prepend\"">  <div class=\""btn-group mb-3\"">"" +
                ""<button type=\""button\"" onclick=\""IncreaseSellUnits("" + i + "")\"" class=\""btn btn-outline-success\"" style=\""border-radius: 0px; width: 25px; height: 20px; padding-top: 0px; padding-bottom: 20px; \"">+</button>"" +
                ""<button type=\""button\"" onclick=\""DecreaseSellUnits("" + i + "")\"" class=\""btn btn-outline-danger\"" style=\""width:25px; height:20px; padding-top: 0px; padding-bottom: 20px; float: right;\"">-</button>"" +
                ""</div></div></div>"" +
                ""<span style=\""margin-left:10px\""> Unidades</span>"" +
                ""<button type=\""button\"" onclick=\""RemoveProductFromEditInventory("" + i + "")\"" class=\""btn btn-sm btn-outline-danger\"" style=\""width:25px; height:20px;  padding-top: 0px; padding-bottom: 20px; margin-left:100px;\""> x </button>"" +
                ""</div></ul > "" +
                ""</li>"").appendTo(EditProducts);



            //Calculate sale tota");
            WriteLiteral(@"l price
            totalPrice2 = totalPrice2 + (EditProductsList[i].productPrice * totalUnits[i]);

            $(totalPrice).empty();
            $(totalProducts).empty();

            //Update sale total price
            $(""<span class=\""price\"" + id=\""totalPrice\"">"" + totalPrice2 + ""$"" +
                ""</span>"").appendTo(totalPrice);

            //Update sale total articles
            $(""<span class=\""price\"" id=\""totalProducts\""> "" + totalUnits2 + "" Units"" +
                ""</span >"").appendTo(totalProducts);


            //console.log(totalUnits2 + "" NEP NEPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP"");

        }
        //Total price = 0 when there is not products on sale
        totalPrice2 = 0;



    }

    // Check if EditProductsList contains a certain product
    function EditProductsContains(SearchProduct) {
        for (var i = 0; i < EditProductsList.length; i++) {
            //console.log(""SearchProduct"", SearchProduct);
            //console.log(""EditProductsList"", E");
            WriteLiteral(@"ditProductsList[i]);
            if (EditProductsList[i].id == SearchProduct.id) {
                return true;
            }
        }

        return false;
    }

    function SearchApproved() {

        // Deny search
        SearchApprovedBool = false;

        setTimeout(function () {

            // Delay next search for 1/10 second
            SearchApprovedBool = true;
        }, 100);
    }

</script>



<div class=""leftpane"">
    <div class=""order-scroller"">
        <div class=""order"">
            <div class=""ordeline"" id=""EditProducts"">
                <li id=""EditProduct"" class=""orderline"">
                    <!--
                                    <span class=""product-name"">caca</span>
                                    <span class=""price""> cacota7</span>
                                    <ul class=""info-list"">

                    <div class=""btn-toolbar mb-4"">

                        <div class=""input-group"">
                            <input type=""");
            WriteLiteral(@"text"" class=""form-control"" placeholder=""0"" style=""width:50px;  height:22px;"">
                            <div class=""input-group-prepend"">
                                <div class=""btn-group  mb-3"">
                                    <button type=""button"" class=""btn btn-outline-success"" style=""border-radius:0px; width:25px; height:20px; padding-top: 0px; padding-bottom: 20px;"">+</button>
                                    <button type=""button"" class=""btn btn-outline-danger"" style=""width:25px; height:20px; padding-top: 0px; padding-bottom: 20px; float: right;"">-</button>
                                </div>
                            </div>

                        </div>
                        <span style=""margin-right:auto; margin-left:10px""> Unidades</span>
                        <button type=""button"" class=""btn btn-sm btn-outline-danger"" style=""width:25px; height:20px; padding-top: 0px; padding-bottom: 20px;""> x </button>
                    </div>
                        -->
       ");
            WriteLiteral(@"             </ul>

                </li>
            </div>
        </div>
    </div>
</div>
<div class=""minipane"">
    <div class=""subwindow-container"">
        <div class=""subwindow-container-fix pads"">
            <div class=""container"">
                <br />
                <center><h4>Resumen de la venta</h4></center>
                <span class=""product-name"">Total de la venta</span>
                <span class=""price"" id=""totalPrice"">0$</span>
                <span class=""product-name"">Total de articulos</span>
                <span class=""price"" id=""totalProducts""> 0 Units</span>
                <div class=""justify-content-md-center"">
                    <br />
                    <button type=""button"" class=""btn btn-outline-danger totalButtons offset-2"">Cancelar</button>
                    <button type=""button"" class=""btn btn-outline-success totalButtons"">Totalizar</button>
                </div>
            </div>
        </div>
    </div>
</div>

<style>

    .card {");
            WriteLiteral(@"
        margin-left: 40px;
        margin-bottom: 20px;
    }

        .card .btn-outline-info {
            bottom: 0;
        }

    .totalButtons {
        padding: 30px 30px;
    }

    .leftpane {
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        box-sizing: border-box;
        position: absolute;
        left: 0;
        width: 400px;
        top: 70px;
        bottom: 250px;
        border-right: solid 1px #CECBCB;
        border-right: solid 3px #787878;
        background: #ffffff;
    }

    .minipane {
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        box-sizing: border-box;
        position: absolute;
        left: 0;
        width: 400px;
        top: 719px;
        bottom: 0px;
        border-right: solid 1px #CECBCB;
        border-right: solid 3px #787878;
        background: rgb(233,233,233);
    }

    .order-scroller {
        width: 100%;
        height: 100%;
        overflow");
            WriteLiteral(@": hidden;
        overflow-y: auto;
    }

    .order {
        background: white;
        padding-bottom: 8px;
        padding-top: 8px;
        font-size: 16px;
        text-align: left;
        max-width: 500px;
    }

    .orderline {
        width: 100%;
        margin: 0px;
        padding-top: 3px;
        padding-bottom: 10px;
        padding-left: 15px;
        padding-right: 15px;
        cursor: pointer;
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        -ms-box-sizing: border-box;
        box-sizing: border-box;
        -webkit-transition: background 250ms ease-in-out;
        -moz-transition: background 250ms ease-in-out;
        transition: background 250ms ease-in-out;
    }

    .info-list {
        color: #888;
        margin-left: 10px;
    }

    .product-name {
        padding: 0;
        display: inline-block;
        font-weight: bold;
        width: 80%;
        overflow: hidden;
        text-overflow: ellipsis;
            WriteLiteral(@"
    }


    .price {
        padding: 0;
        font-weight: bold;
        float: right;
    }

    .info-list {
        color: #888;
        margin-left: 10px;
    }

    em {
        color: #777;
        font-weight: bold;
        font-style: normal;
    }

    ::-webkit-scrollbar {
        width: 4px;
    }

    /* Track */
    ::-webkit-scrollbar-track {
        background: rgb(224,224,224);
        border-left: solid 1px rgb(200,200,200);
    }

    /* Handle */
    ::-webkit-scrollbar-thumb {
        background: rgb(168,168,168);
        background: #393939;
        min-height: 30px;
    }

    li {
        list-style: none;
    }

    .subwindow-container {
        height: 100%;
        display: table-cell;
        position: relative;
    }

    .subwindow-container {
        display: table-cell;
        position: relative;
    }

    .pads {
        border-top: solid 3px rgb(131, 131, 131);
        width: 400px;
    }

    .product {
        ");
            WriteLiteral(@"position: relative;
        vertical-align: top;
        display: inline-block;
        line-height: 100px;
        font-size: 11px;
        margin: 8px !important;
        width: 122px;
        height: 115px;
        background: #fff;
        border: 1px solid #e2e2e2;
        border-radius: 3px;
        border-bottom-width: 3px;
        overflow: hidden;
        cursor: pointer;
    }

    .footer {
        display: none;
    }
</style>


<!-- Basura original
 $(""<li id=\""EditProduct"" + i + ""\""class=\""orderline\"">"" +
                ""<span class=\""product-name\"">"" + EditProductsList[i].productName + ""</span>"" +
                ""<span class=\""price\"">"" + ""$"" + EditProductsList[i].productPrice + ""</span>"" +
                ""<ul class=\""info-list\"">"" + ""<em> 5.000</em> Unidades por "" +  ""$"" + EditProductsList[i].productPrice +""/Unidad </em>"" + //Arreglar para que sea dinamico
                ""<button type=\""button\"" onclick=\""RemoveProductFromEditInventory("" + i + "")\"" class=\""btn bt");
            WriteLiteral("n-sm btn-outline-danger\\\" style=\\\"width:25px; height:20px;  padding-top: 0px; padding-bottom: 20px; float: right;\\\"> x </button>\" +\r\n                \"</ul > \" +\r\n                \"</li>\").appendTo(EditProducts);\r\n-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Sell_SellingMainPage> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Sell_SellingMainPage> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Sell_SellingMainPage>)PageContext?.ViewData;
        public Pages_Sell_SellingMainPage Model => ViewData.Model;
    }
}
#pragma warning restore 1591