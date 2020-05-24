// Global variables
var PageTitle = document.title.slice(0, -8); // Page title
var InOrOutRadioBtn = "In"; // Select if products ar going in or out
var SearchApprovedBool = true; // If another search is avaible or you must wait
var SearchProductsList = []; // List of products returned by databese after search
var MovementProductsList = []; // Secondary list of products. For now "Edit Products" or "Selling products"
var SellingProductsUnits = []; // The units of each product to sell
var TotalPrice = 0; // The total price of all selling products
var TotalUnits = 0; // The total units of products to sell
var StockInOutList = []; // List of movements returned by databese

function Sell() {
    
    // Assume new stock values are valid
    var ValidSell = true;
    
    //Validates that there is 1 or more products on the movement products list
    if (MovementProductsList.length < 1) {
        ValidSell = false;
    } else {
        ValidSell = true;
    }

    // Loop trhought selling products
    for (var i = 0; i < MovementProductsList.length; i++) {
        // Create a variable to save the product id of the edit products
        var NewProductStockId = "#ProductStock" + i;
        var NewProductStock = parseInt($(NewProductStockId).val());
        
        // Check if new stock is non negative, is an integer
        if (
            MovementProductsList[i].ProductStock < NewProductStock ||
            !Number.isInteger(NewProductStock) ||
            NewProductStock <= 0 ||
            NewProductStock > 200)
        {
            ValidSell = false;
            break;
        }

        // Update selling products stock with selling units
        MovementProductsList[i].ProductStock = SellingProductsUnits[i];
    }

    if (ValidSell) {
        // Make the AJAX request to create a receipt and finish a sell
        $.ajax({
            type: "POST",
            url: "/Sell/BasicSell",
            data: {
                // Confirm is a stock movement
                TotalPrice: TotalPrice,

                // Send products to sell in JSON
                MovementProductsListJSON: JSON.stringify(MovementProductsList)
            },
            // If the request is successfull
            success: function (response) {

                // Create Receipt
                var Receipt = new jsPDF();
                var row = 40;
                
                // Add title to receipt
                Receipt.text(20, 20, 'Recibo de venta');
                Receipt.text(20, 30, '-----------------------------');
                
                // Loop throught sold products
                for (var i = 0; i < MovementProductsList.length; i++) {
                    Receipt.text(20, row, 'Producto: ' + MovementProductsList[i].ProductName);
                    row += 10;

                    Receipt.text(20, row, 'Precio: ' + MovementProductsList[i].ProductPrice);
                    row += 10;

                    Receipt.text(20, row, 'Cantidad: ' + MovementProductsList[i].ProductStock);
                    row += 10;

                    Receipt.text(20, row, '-----------------------------');
                    row += 10;

                    
                }
                Receipt.text(20, row, 'Total a pagar: ' + TotalPrice);
                row += 10;

                // Save the PDF
                Receipt.autoPrint();
                Receipt.output('dataurlnewwindow');
                //Receipt.save('document.pdf');

                // Get the new stock from the server
                //MovementProductsList = Array.from(JSON.parse(response));
                for (var n = 0; n < MovementProductsList.length; n++) {
                    SellingProductsUnits[n] = 1;
                }
                // Remove all products from selling
                MovementProductsList.length = 0;

                // Update Lists
                SearchProduct($("#SearchBar").val());
            }
        });
    } else {
        // Show modal of invalid value
        $("#InvalidValueModal").modal();

        // Update Lists
        SearchProduct($("#SearchBar").val());
    }
}

function CancelSell() {
    // Remove all products from selling
    MovementProductsList.length = 0;

    // Update Lists
    SearchProduct($("#SearchBar").val());
}

function StockZero() {
    // Make the AJAX request to make every product stock zero
    $.ajax({
        type: "GET",
        url: "/Inventory/StockZero",
        dataType: "json",
        // If the request is successfull
        success: function () {

            // Close the modal
            $("#ConfirmModal").modal("hide");

            // Update the Lists
            UpdateLists();
        }
    });
}

function ModifyStock() {
    // Assume new stock values are valid
    var ValidNewStock = true;

    // Save the selection of in or out
    if ($(InStockRadioBtn).is(':checked')) {
        InOrOutRadioBtn = "In";
    } else {
        InOrOutRadioBtn = "Out";
    }

    //Validates that there is 1 or more products on the movement products list
    if (MovementProductsList.length < 1) {

        ValidNewStock = false;
    } else {
        ValidNewStock = true;
    }

    // Update local stock values
    for (var i = 0; i < MovementProductsList.length; i++) {
        // Create a variable to save the product id of the edit products
        var NewProductStockId = "#ProductStock" + i;
        var NewProductStock = parseInt($(NewProductStockId).val());

        if ((InOrOutRadioBtn == "Out" &&
            MovementProductsList[i].ProductStock < NewProductStock) ||
            (!Number.isInteger(NewProductStock) ||
                NewProductStock <= 0 ||
            NewProductStock > 1000000000)
        ) {
            ValidNewStock = false;
            break;
        }

        // Update the stock value of teh edit products by the user input
        MovementProductsList[i].ProductStock = parseInt($(NewProductStockId).val());
    }
    
    if (ValidNewStock) {
        SaveStock(InOrOutRadioBtn);
    } else {
        $("#InvalidValueModal").modal();
    }

}

function SaveStock(InOrOutRadioBtn) {
    // Make the AJAX request to save modifications in products of stock
    $.ajax({
        type: "POST",
        url: "/Inventory/SaveStock",
        data: {
            // Send the selection of in or out
            InOrOutString: InOrOutRadioBtn,

            // Confirm is a stock movement
            StockOrSaleString: "Stock",

            // Send products to modify in JSON
            MovementProductsListJSON: JSON.stringify(MovementProductsList)
        },
        // If the request is successfull
        success: function (response) {

            // Update stock from changes
            MovementProductsList = Array.from(JSON.parse(response));

            // Update the Lists
            UpdateLists();
        }
    });
}

// Gets called to search by the search bar
function SearchProduct(SearchWord) {

    // If search is approved by time
    if (SearchApprovedBool) {

        // Clear Search Products List
        $("#SearchProducts").empty();

        // If the search bar has content
        if (SearchWord.length > 0) {
            $("<th scope=\"row\"> Cargando... </th>").appendTo(SearchProducts);

            // Make the AJAX request to search products
            $.ajax({
                type: "GET",
                url: "/Products/SearchProduct",
                dataType: "json",
                data: {
                    SearchString: SearchWord
                },
                contentType: 'application/json; charset=utf-8',
                // If the request is successfull
                success: function (Response) {

                    // Set the products to the global variable
                    SearchProductsList = Array.from(JSON.parse(Response));

                    // Update Lists HTML
                    UpdateLists();

                    // Check if any product was found
                    if (SearchProductsList.length == 0) {
                        // Clear Search Products List
                        $("#SearchProducts").empty();

                        // No product returned by the server
                        $("<th scope=\"row\"><td colspan=\"3\" > Ningún producto coincide con la busqueda </td> </th>").appendTo(SearchProducts);
                    }
                }
            });
        } else {
            // Clear Search Products List
            $("#SearchProducts").empty();

            // Show the user haven't search anything
            $("<th scope=\"row\"><td colspan=\"3\"> Ninguna busqueda realizada </td> </th>").appendTo(SearchProducts);
        }

        // Deny search
        SearchApproved();
    }
}

function AddProductToMovementInventory(ProductIndex) {

    // Add the product to the list of editing products
    MovementProductsList.push(SearchProductsList[ProductIndex]);

    // Remove the product from the list of searched products
    SearchProductsList.splice(ProductIndex, 1);

    // Update Lists
    SearchProduct($("#SearchBar").val());
}

function RemoveProductFromMovementInventory(ProductIndex) {
    // Remove the product from the list of editing products
    MovementProductsList.splice(ProductIndex, 1);
    
    if (PageTitle == 'SellMain')
    {
        //Delete product units from total
        TotalUnits -= TotalUnits[ProductIndex];

        //Delete product units from array of product units
        SellingProductsUnits.splice(ProductIndex, 1);
    }

    // Update Lists
    SearchProduct($("#SearchBar").val());
}

// Update Lists
function UpdateLists() {
    // Clear Search Products List
    $("#SearchProducts").empty();

    // Clear Edit Products List HTML
    if ($('#MovementProducts').length) { $("#MovementProducts").empty(); }

    switch (PageTitle) {
        // Products page
        case 'Products':
            UpdateProductsLists();

            break;
        // Inventory movements page
        case 'InventoryMovement':
            
            // Update lists
            UpdateInventoryMovementLists()

            break;

        // Selling main page
        case 'SellMain':
            // Update lists
            UpdateSellMainLists()

            break;

        // Inventory AI page
        case 'InventoryAI':
            // Update lists
            UpdateInventoryAILists()

            break;

        // Default - Probably error
        default:
            console.log("Error. View not found.");
            // Crear modal de error.
    }
}

// Products lists
function UpdateProductsLists() {
    // Fill the list with the products returned by the server
    for (var i = 0; i < SearchProductsList.length; i++) {
        if (SearchProductsList[i].ProductActive) {
            var RowString = "<tr >" + " <th scope=\"row\" style=\"width:149.35px\">" + SearchProductsList[i].ProductName + "</th>" +
                "<td class=\"tableSize\">" + SearchProductsList[i].ProductPrice + "</td>" +
                "<td  class=\"tableSize\">" + SearchProductsList[i].ProductStock + "</td>" +
                "<td  class=\"tableSize\">" + SearchProductsList[i].ProductCost + "</td>" +
                "<td  class=\"tableSize3\"><button " +
                "type=\"button\"" +
                "onclick=\"OpenProductModal('EditProductModal', " + i + ")\"" +
                "class=\"btn btn-sm btn-outline-primary\"" +
                "data-toggle=\"modal\"" +
                "data-target=\"#ProductModal\"> Editar </button> </td>" +
                "<td class=\"tableSize3\"><button type=\"button\" onclick=\"ActivateProduct(" + i + ", false)\" class=\"btn btn-sm btn-outline-danger\"> Desactivar </button> </td > ";
        }
        else {
        var RowString = "<tr >" + " <th scope=\"row\"  style=\"color:gray; width:149.35px\">" + SearchProductsList[i].ProductName + "</th>" +
                "<td class=\"tableSize\" style=\"color:gray\">" + SearchProductsList[i].ProductPrice + "</td>" +
                "<td  class=\"tableSize\" style=\"color:gray\">" + SearchProductsList[i].ProductStock + "</td>" +
                "<td  class=\"tableSize\" style=\"color:gray\">" + SearchProductsList[i].ProductCost + "</td>" +
                "<td class=\"tableSize3\"><button " +
                "type=\"button\"" +
                "onclick=\"OpenProductModal('EditProductModal', " + i + ")\"" +
                "class=\"btn btn-sm btn-outline-primary\"" +
                "data-toggle=\"modal\"" +
                "data-target=\"#ProductModal\"> Editar </button> </td>" +
                "<td  class=\"tableSize3\"><button type=\"button\" onclick=\"ActivateProduct(" + i + ", true)\" class=\"btn btn-sm btn-outline-success\"> Activar </button> </td > ";
        }

        var RowString = RowString + "</tr>"

        $(RowString).appendTo(SearchProducts);
    }
}

// Inventory movement update lists
function UpdateInventoryMovementLists() {

    // Fill the list with the products returned by the server
    for (var i = 0; i < SearchProductsList.length; i++) {
        // If the Product is not being edit yet
        if (!MovementProductsContains(SearchProductsList[i]) && SearchProductsList[i].ProductActive) {
            $("<tr >" + " <th scope=\"row\" style=\"width:220px\">" + SearchProductsList[i].ProductName + "</th>" +
                "<td style=\"width:170px\">" + SearchProductsList[i].ProductPrice + "</td>" +
                "<td style=\"width:90px\">" + SearchProductsList[i].ProductStock + "</td>" +
                "<td><button type=\"button\" onclick=\"AddProductToMovementInventory(" + i + ")\" class=\"btn btn-sm btn-outline-success\"> > </button> </td>" +
                "</tr>").appendTo(SearchProducts);
        }
    }
    
    // Update Edit Products List
    if (MovementProductsList.length == 0) {
        // No product added to edit list
        $("<th scope=\"row\"><td colspan=\"3\" style=\"height: 30vh\"> No se ha añadido ningún producto</td> </th>").appendTo("#MovementProducts");
    } else {
        // Add products to edit list
        for (var i = 0; i < MovementProductsList.length; i++) {
            $("<tr >" + " <th scope=\"row\" style=\"width:215px\">" + MovementProductsList[i].ProductName + "</th>" +
                "<td style=\"width:85px\">" + MovementProductsList[i].ProductStock + "</td>" +
                "<td><input " +
                "id =\"ProductStock" + i + "\"" +
                "class=\" form-control formStyle\"" +
                "style= \"margin-left:60px; width:88px; text-align:center\"" +
                "type=\"number\"" +
                "min=\"0\"" +
                "value=\"0\"" +
                "placeholder=\"Unidades\"></td>" +
                "<td><button type=\"button\" onclick=\"RemoveProductFromMovementInventory(" + i + ")\" class=\"btn btn-sm btn-outline-danger\"> x </button> </td>" +
                "</tr>").appendTo("#MovementProducts");
        }
    }
}

function UpdateInventoryAILists() {

    // Fill the list with the products returned by the server
    for (var i = 0; i < SearchProductsList.length; i++) {
        // If the Product is not being edit yet
        if (!MovementProductsContains(SearchProductsList[i]) && SearchProductsList[i].ProductActive) {
            $("<tr >" + " <th scope=\"row\" style=\"width:220px\">" + SearchProductsList[i].ProductName + "</th>" +
                "<td style=\"width:170px\">" + SearchProductsList[i].ProductPrice + "</td>" +
                "<td style=\"width:90px\">" + SearchProductsList[i].ProductStock + "</td>" +
                "<td><button type=\"button\" onclick=\"AddProductToMovementInventory(" + i + ")\" class=\"btn btn-sm btn-outline-success\"> > </button> </td>" +
                "</tr>").appendTo(SearchProducts);
        }
    }

    // Update predict products List
    if (MovementProductsList.length == 0) {
        // No product added to edit list
        $("<th scope=\"row\"><td colspan=\"3\"> No se ha añadido ningún producto</td> </th>").appendTo("#MovementProducts");
    } else {
        // Add products to edit list
        for (var i = 0; i < MovementProductsList.length; i++) {
            $("<tr >" + " <th scope=\"row\" style=\"width:200px\">" + MovementProductsList[i].ProductName + "</th>" +
                "<td style=\"width:200px\">" + MovementProductsList[i].ProductStock + "</td>" + // Unidades predecidas
                "<td style=\"width:85px\">" + MovementProductsList[i].ProductCost + "</td>" + // Precio predecido
                "<td><button type=\"button\" onclick=\"RemoveProductFromMovementInventory(" + i + ")\" class=\"btn btn-sm btn-outline-danger\"> x </button> </td>" +
                "</tr>").appendTo("#MovementProducts");
        }
    }
}

// Update Lists
function UpdateSellMainLists() {

    // Fill the list with the products returned by the database
    for (var i = 0; i < SearchProductsList.length; i++) {
        // If the Product is active
        if (!MovementProductsContains(SearchProductsList[i]) && SearchProductsList[i].ProductActive) {
            $("<div id=\"SearchProduct" + i + "\" class=\"card justify-content-center\"  style=\"width: 12rem;\">" +
                " <div class=\"card-body\">" +
                "<h5 class=\"card-title\" style=\"text-align:center; font-weight: bold\">" + SearchProductsList[i].ProductName + "</h5>" +
                "<h6 class=\"card-subtitle mb-2 text-muted\"  style=\"text-align:center\">" + SearchProductsList[i].ProductStock + " Unidades" + "</h6>" +
                "<p class=\"card-text\" style=\"text-align:center\">" + SearchProductsList[i].ProductPrice + " $" + "</p>" +
                "<button type=\"button\" style=\"margin-left:3.6vh\" onclick=\"AddProductToMovementInventory(" + i + ")\" class=\"btn btn-outline-info\"> Agregar </button>" +
                "</div > " +
                "</div>").appendTo(SearchProducts);
        }
    }

    // Clear selling price and units
    TotalPrice = 0;
    TotalUnits = 0;

    // Update Edit Products List
    for (var i = 0; i < MovementProductsList.length; i++) {

        if (SellingProductsUnits[i] == null) { SellingProductsUnits[i] = 1; }

        $("<li id=\"EditProduct" + i + "\"class=\"orderline\">" +
            "<span class=\"product-name\">" + MovementProductsList[i].ProductName + "</span>" +
            "<span class=\"price\"> $" + (MovementProductsList[i].ProductPrice * SellingProductsUnits[i]) + "</span>" +
            "<ul class=\"info-list\">" + "<div class=\"btn-toolbar mb-4\"> <div class=\"input-group\">" +
            "<input type=\"text\" onChange=\"ChangeUnitsManually(" + i + ")\" id=\"ProductStock" + i + "\" value=" + SellingProductsUnits[i] + " class=\"form-control\" style=\"width: 50px; height: 22px; \"> <div class=\"input-group-prepend\"> <div class=\"input-group-prepend\">  <div class=\"btn-group mb-3\">" +
            "<button type=\"button\" onclick=\"IncreaseSellUnits(" + i + ")\" class=\"btn btn-outline-success\" style=\"border-radius: 0px; width: 25px; height: 20px; padding-top: 0px; padding-bottom: 20px; \">+</button>" +
            "<button type=\"button\" onclick=\"DecreaseSellUnits(" + i + ")\" class=\"btn btn-outline-danger\" style=\"width:25px; height:20px; padding-top: 0px; padding-bottom: 20px; float: right;\">-</button>" +
            "</div></div></div>" +
            "<span style=\"margin-left:10px;margin-right:60px\"> Unidades </span>" +
            "<button type=\"button\" onclick=\"RemoveProductFromMovementInventory(" + i + ")\" class=\"btn btn-sm btn-outline-danger\" style=\"width:25px; height:20px;  padding-top: 0px; padding-bottom: 20px\"> x </button>" +
            "</div></ul > " +
            "</li>").appendTo(MovementProducts);
        
        // Calculate total selling price
        TotalPrice += (MovementProductsList[i].ProductPrice * SellingProductsUnits[i]);

        // Calculate total selling units
        TotalUnits += SellingProductsUnits[i];
    }

    // If there are products on sale
    if (TotalUnits != 0) {
        // Update sale total price
        $("#TotalPrice").text('$' + TotalPrice);

        // Update sale total articles
        $("#TotalUnits").text(TotalUnits);
    } else {
        // There are no products on sale
        $("#TotalPrice").text('$0');
        $("#TotalUnits").text('0');
    }
}

// Increase # units using + button
function IncreaseSellUnits(ProductIndex) {
    // Increase product units
    SellingProductsUnits[ProductIndex]++;

    // Increase total products units
    TotalUnits++;

    // Update lists
    UpdateLists();
}

// Decrease # units using - button
function DecreaseSellUnits(ProductIndex) {
    if (SellingProductsUnits[ProductIndex] <= 1) {
        // Remove the product from the selling list
        RemoveProductFromMovementInventory(ProductIndex);

    } else {
        // Decrease product units
        SellingProductsUnits[ProductIndex]--;

        // Decrease total products units
        TotalUnits--;

        // Update lists
        UpdateLists();
    }
}

// Check if Edit Products List contains a certain product
function MovementProductsContains(SearchProduct) {
    // Loop throught the List
    for (var i = 0; i < MovementProductsList.length; i++) {
        if (MovementProductsList[i].Id == SearchProduct.Id) {
            return true;
        }
    }

    return false;
}

// Stop next search for a short period of time
function SearchApproved() {

    // Deny search
    SearchApprovedBool = false;

    setTimeout(function () {

        // Delay next search for 1/10 second
        SearchApprovedBool = true;
    }, 100);
}

// Activate/Deactive product
function ActivateProduct(ProductIndex, ActiveBool) {

    // Get the product to delete
    var ProductToActivate = SearchProductsList[ProductIndex];

    // Make the AJAX request to delete a product
    $.ajax({
        type: "POST",
        url: "/Products/ActivateProduct",
        data: {
            ProductToActivateJSON: JSON.stringify(ProductToActivate),
            ActiveBoolJSON: JSON.stringify(ActiveBool)
        },
        // If the request is successfull
        success: function () {
            // Reload search
            SearchProduct($("#SearchBar").val());
        }
    });
}

// Edit/Create product modal
function OpenProductModal(Modal, ProductIndex) {

    // Saved product
    var Product = null;

    switch (Modal) {
        // Create product
        case 'CreateProductModal':
            // Set product to null
            Product = null;

            // Change the title of the modal
            $("#ModalTitle").text("Crear Producto");

            // Change the action url of the modal
            $("#ProductForm").attr("action", "/Products/CreateProduct");

            // Assign values to the create product modal
            $("#ProductId").val("");
            $("#ProductName").val("");
            $("#ProductPrice").val("");
            $("#ProductCost").val("");
            $("#ProductStock").attr("placeholder", "Unidades iniciales del producto");
            $("#ProductStockTitle").text("Inventario inicial");
            $("#ProductStock").val("");
            $("#ProductStock").prop("readonly", false);
            $("#SuccessModalButton").text("Crear");

            break;

        // Edit a product values
        case 'EditProductModal':

            // Get the selected product to edit
            Product = SearchProductsList[ProductIndex];

            // Change the title of the modal
            $("#ModalTitle").text("Editar Producto");

            // Change the action url of the modal
            $("#ProductForm").attr("action", "/Products/EditProduct");

            // Assign values to the edit product modal
            $("#ProductId").val(Product.Id);
            $("#ProductName").val(Product.ProductName);
            $("#ProductPrice").val(Product.ProductPrice);
            $("#ProductCost").val(Product.ProductCost);
            $("#ProductStock").attr("placeholder", "Productos en inventario");
            $("#ProductStockTitle").text("Unidades");
            $("#ProductStock").val(Product.ProductStock);
            $("#ProductStock").prop("readonly", true);
            $("#SuccessModalButton").text("Actualizar");

            break;

        // Default - Probably error
        default:
            console.log("Error");
        // Crear modal de error.
    }
}

// Get the latest entries of stock in out
function GetLatestStockInOut() {
    $("#StockInOutList").empty();

    // Make the AJAX request to get latest entries of stock in out
    $.ajax({
        type: "GET",
        url: "/Inventory/LatestStockInOut",
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        // If the request is successfull
        success: function (Response) {

            // Temporal variable to store translation
            var InOut = '';
            var StockOrSale = '';

            // Set to an array the latest entries of stock in out
            StockInOutList = Array.from(JSON.parse(Response));

            // Add products to edit list
            for (var i = 0; i < StockInOutList.length; i++) {
               
                if (StockInOutList[i].InOrOut == "In") {
                    InOut = "Entrada";
                } else {
                    InOut = "Salida";
                }
                if (StockInOutList[i].StockOrSale == "Sale") {
                    StockOrSale = "Venta";
                } else {
                    StockOrSale = "Traslado";
                }
                $("<tr> <th scope=\"row\"class=\"tableSizeExtra\">" + i + "</th>" +
                    "<td class=\"tableSize\">" + StockInOutList[i].StockInOutDate + "</td>" +
                    "<td class=\"tableSize\">" + StockInOutList[i].TotalPrice + "</td>" +
                    "<td class=\"tableSize\">" + StockOrSale + "</td>" +
                    "<td class=\"tableSize\">" + InOut + "</td>" +
                    "<td><button " +
                    "type=\"button\"" +
                    "onclick =\"StockInOutDetails('" + StockInOutList[i].Id + "', " + i + ")\"" +
                    "class=\"btn btn-sm btn-outline-primary\"" +
                    "data-toggle=\"modal\"" +
                    "data-target=\"#DetailsStockInOutModal\"> Detalles </button> </td>" +
                    "</tr>").appendTo("#StockInOutList");
            }
        }
    });
}

function StockInOutDetails(SpecificMovementId, MovementIndex) {

    // Make the AJAX request to get a specific movement
    $.ajax({
        type: "GET",
        url: "/Inventory/SpecificMovementProducts",
        dataType: "json",
        data: {
            SpecificMovementId: SpecificMovementId
        },
        contentType: 'application/json; charset=utf-8',
        // If the request is successfull
        success: function (Response) {

            // Set to an array the latest entries of stock in out
            var SpecificMovementProducts = Array.from(JSON.parse(Response));

            //console.log(SpecificMovementProducts);

            // Empty the table body
            $("#MovementDetails").empty();

            for (var i = 0; i < SpecificMovementProducts.length; i++) {
                
                // Add each product
                $("<tr id=\"Product" + i + "\">" +
                    "<th scope=\"row\" style=\"min-width:50px;max-width:50px\">" + SpecificMovementProducts[i].ProductName + "</th >" +
                    "<td>" + SpecificMovementProducts[i].StockChange + "</td>" +
                    "</tr>").appendTo("#MovementDetails");
            }
        }

    });

}

function CheckPassword() {
    // Get password values from form
    var Password = form.Password.value;
    var ConfirmPassword = form.ConfirmPassword.value;

    // Check if password are the same  
    if (Password != ConfirmPassword) {
        // Toggle a modal to alert user passwords don't match
        $('#CheckPasswordModal').modal('toggle');

        return false;
    } else {
        return true;
    }
}

function PredictProducts(/*DateToPredict*/) {
    var DateToPredict = "04/04/2020";

    // Make the AJAX request to get last 12 months sells of products
    $.ajax({
        type: "GET",
        url: "/Inventory/PreviousSoldProducts",
        dataType: "json",
        data: {
            // Products on movement list
            MovementProductsListJSON: JSON.stringify(MovementProductsList),

            // Confirm is a stock movement
            DateToPredict: DateToPredict
        },
        contentType: 'application/json; charset=utf-8',
        // If the request is successfull
        success: function (Response) {

            var CleanProductsToPredictList = [];
            
            // Set the products to the global variable
            var ProductsToPredictList = Array.from(JSON.parse(Response));

            //console.log("ReturnedList: ", ProductsToPredictList);

            for (var i = 0; i < MovementProductsList.length; i++) {
                CleanProductsToPredictList[i] = [];
                CleanProductsToPredictList[i].Id = MovementProductsList[i].Id;
                CleanProductsToPredictList[i].ProductName = MovementProductsList[i].ProductName;
                CleanProductsToPredictList[i].ProductPrice = MovementProductsList[i].ProductPrice;
                CleanProductsToPredictList[i].ProductCost = MovementProductsList[i].ProductCost;

                for (var j = 0; j < ProductsToPredictList.length; j++) {

                    if (MovementProductsList[i].Id == ProductsToPredictList[j].Id) {
                        var MonthIndex = ProductsToPredictList[j].StockInOutDate.substr(3, 2);
                        if (MonthIndex < 10) {
                            MonthIndex = ProductsToPredictList[j].StockInOutDate.substr(4, 1);
                        } 
                        if (CleanProductsToPredictList[i][MonthIndex] == null) {
                            CleanProductsToPredictList[i][MonthIndex] = [];
                        }

                        if (CleanProductsToPredictList[i][MonthIndex].StockChange != null) {
                            CleanProductsToPredictList[i][MonthIndex].StockChange += ProductsToPredictList[j].StockChange;
                        } else {
                            CleanProductsToPredictList[i][MonthIndex].StockChange = 0;
                            CleanProductsToPredictList[i][MonthIndex].StockChange += ProductsToPredictList[j].StockChange;
                        }
                        
                        CleanProductsToPredictList[i][MonthIndex].StockInOutDate = ProductsToPredictList[j].StockInOutDate;
                    }
                }
            }

            NeuralNetwork(CleanProductsToPredictList, DateToPredict);
            
        }
    });
}

function NeuralNetwork(CleanProductsToPredictList, DateToPredict) {
    /*
    console.log(CleanProductsToPredictList[0][5].StockChange);
    console.log(CleanProductsToPredictList[0][6].StockChange);
    console.log(CleanProductsToPredictList[0][7].StockChange);
    console.log(CleanProductsToPredictList[0][8].StockChange);
    console.log(CleanProductsToPredictList[0][9].StockChange);
    console.log(CleanProductsToPredictList[0][10].StockChange);
    console.log(CleanProductsToPredictList[0][11].StockChange);
    console.log(CleanProductsToPredictList[0][12].StockChange);
    console.log(CleanProductsToPredictList[0][1].StockChange);
    console.log(CleanProductsToPredictList[0][2].StockChange);
    console.log(CleanProductsToPredictList[0][3].StockChange);
    console.log(CleanProductsToPredictList[0][4].StockChange);
    */

    var nnResults = [];

    for (var i = 0; i < MovementProductsList.length; i++) {
        //console.log(MovementProductsList.length + "nep");

        var highestSell = 0;

        for (var nep = 1; nep < 13; nep++) {
            if (CleanProductsToPredictList[i][nep].StockChange > highestSell) {
                highestSell = CleanProductsToPredictList[i][nep].StockChange;
            }
        }

        //console.log("Nep sold " + highestSell + " wow nep is amazing ^^");

        //Training and normalize Data
        const trainingData = [];
        //May i'll have to change the order
        for (var j = 4; j > 4 - 12; j--) {
            if (j > 0) {
                trainingData.push({ "soldStock": CleanProductsToPredictList[i][j].StockChange, "price": 1 });
                //console.log(j + " nepuuuuu");
            } else {
                trainingData.push({ "soldStock": CleanProductsToPredictList[i][j + 12].StockChange, "price": 1 });
                //console.log(j + " nepuuuuu");
            }
        }

        //console.log(trainingData);

        const scaledData = trainingData.map(n => normalizeData(n, highestSell));
        // console.log(trainingDataVII[0]);

        const trainingDataVII = [
            scaledData.slice(0, 12)
        ];
        //console.log(trainingDataVII[0]);

       

        // Initialize and design the NN
        const neuralNetwork = new brain.recurrent.LSTMTimeStep({
            inputSize: 2,
            hiddenLayers: [4, 3, 2], //Each value on the array represent a hidden layle and the number is the # of nodes(neurones) in that layer
            outputSize: 2
        });

        //Train the NepUral Network
        neuralNetwork.train(trainingDataVII, {
            learningRate: 0.005,
            errorThresh: 0.002/*,
            log: (stats) => console.log(stats)*/
        });

        //Run the NN
        nnResults[i]= neuralNetwork.forecast(
            [trainingDataVII], 1).map(n => desnormalizeData(n, highestSell));

        //console.log(nnResults[i], MovementProductsList.length);

    }
    eoq(nnResults, CleanProductsToPredictList, DateToPredict);
}


function normalizeData(object, highestSell) {
    return {
        soldStock: object.soldStock / highestSell,
        price: object.price
    };
}

function desnormalizeData(object, highestSell) {
    return {
        soldStock: object.soldStock * highestSell,
        price: object.price
    };
}

function eoq(nnResults, ProductList, DateToPredict){
    var optimalQuanty = [];

    // Testing
    /*
    console.log("nnResults - Sold Stock", nnResults[0][0].soldStock);
    console.log("ProductList - Product Cost", ProductList[0].ProductCost);
    console.log("ProductList - Product Cost * 0.000694", (ProductList[0].ProductCost * 0.000694));
    
    */

    console.log("Date To Predict (eoq)", DateToPredict);

    // Empty the table body
    $("#PredictProductsTableBody").empty();

    for (var i = 0; i < ProductList.length; i++) {
        console.log(nnResults[0][0].soldStock);
        console.log(nnResults[1][0].soldStock);
        // Predict Formula
        //vuestra pinche madre alvaro
        optimalQuanty[i] = Math.sqrt((2 * nnResults[i][0].soldStock * ProductList[i].ProductCost) / (ProductList[i].ProductPrice * 0.02080/*0.000694*/));
        //console.log(ProductList[i].ProductCost);
        //console.log(ProductList[i].ProductPrice);
        // optimalQuanty[i] = Math.sqrt((2 * DEMANDA *COSTO DE ORDENAR)/COSTO DE ALAMCENAR);

        var MonthToPredictString = DateToPredict.slice(3, 5);

        var MonthToPredictInt = parseInt(MonthToPredictString);

        if (MonthToPredictInt >= 12) {
            MonthToPredictInt = "1";
        } else {
            MonthToPredictInt += 1;
        }

        //console.log("Month", MonthToPredict);

        // Modal values
        // Add each product
        $("<tr id=\"Product" + i + "\">" +
            "<th scope=\"row\" style=\"min-width:50px;max-width:50px\">" + ProductList[i].ProductName + "</th >" +
            "<td>" + Math.floor(nnResults[i][0].soldStock) + "</td>" +
            "<td>" + Math.floor(optimalQuanty[i]) + "</td>" +
            "<td>" + MonthToPredictInt + "</td>" +
            "</tr>").appendTo("#PredictProductsTableBody");
    }

    $("#PredictProductsModal").modal();

    console.log("optimalQuanty", optimalQuanty);
}
