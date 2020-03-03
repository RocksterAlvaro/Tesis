// Global variables
var PageTitle = document.title.slice(0, -8);
var InOrOutRadioBtn = "In";
var SearchApprovedBool = true;
var SearchProductsList = [];
var EditProductsList = [];
var LatestStockInOut;
var InOut = [];

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

    // Update local stock values
    for (var i = 0; i < EditProductsList.length; i++) {
        // Create a variable to save the product id of the edit products
        var NewProductStockId = "#ProductStock" + i;
        var NewProductStock = parseInt($(NewProductStockId).val());

        if ((InOrOutRadioBtn == "Out" &&
            EditProductsList[i].ProductStock < NewProductStock) ||
            (!Number.isInteger(NewProductStock) ||
                NewProductStock <= -1 ||
                NewProductStock > 1000000000)
        ) {
            ValidNewStock = false;
            break;
        }

        // Update the stock value of teh edit products by the user input
        EditProductsList[i].ProductStock = parseInt($(NewProductStockId).val());
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
            EditProductsListJSON: JSON.stringify(EditProductsList)
        },
        // If the request is successfull
        success: function (response) {

            // Update stock from changes
            EditProductsList = Array.from(JSON.parse(response));

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
                        $("<th scope=\"row\"><td colspan=\"3\"  style=\"height: 43vh\"> Ningún producto coincide con la busqueda </td> </th>").appendTo(SearchProducts);
                    }
                }
            });
        } else {
            // Clear Search Products List
            $("#SearchProducts").empty();

            // Show the user haven't search anything
            $("<th scope=\"row\"><td colspan=\"3\" style=\"height: 43vh\"> Ninguna busqueda realizada </td> </th>").appendTo(SearchProducts);
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

    // Update Lists
    SearchProduct($("#SearchBar").val());
}

function RemoveProductFromEditInventory(ProductIndex) {
    // Remove the product from the list of editing products
    EditProductsList.splice(ProductIndex, 1);

    // Update Lists
    SearchProduct($("#SearchBar").val());
}

// Update Lists
function UpdateLists() {
    // Clear Search Products List
    $("#SearchProducts").empty();

    switch (PageTitle) {
        // Products page
        case 'Products':
            UpdateProductsLists();

            break;
        // Inventory movements page
        case 'InventoryMovement':

            // Clear Edit Products List HTML
            $("#EditProducts").empty();

            // Update lists
            UpdateInventoryMovementLists()

            break;

        // Default - Probably error
        default:
            console.log("Error");
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
        if (!EditProductsContains(SearchProductsList[i]) && SearchProductsList[i].ProductActive) {
            $("<tr >" + " <th scope=\"row\" style=\"width:220px\">" + SearchProductsList[i].ProductName + "</th>" +
                "<td style=\"width:170px\">" + SearchProductsList[i].ProductPrice + "</td>" +
                "<td style=\"width:90px\">" + SearchProductsList[i].ProductStock + "</td>" +
                "<td><button type=\"button\" onclick=\"AddProductToEditInventory(" + i + ")\" class=\"btn btn-sm btn-outline-success\"> > </button> </td>" +
                "</tr>").appendTo(SearchProducts);
        }
    }
    
    // Update Edit Products List
    if (EditProductsList.length == 0) {
        // No product added to edit list
        $("<th scope=\"row\"><td colspan=\"3\" style=\"height: 43vh\"> No se ha añadido ningún producto</td> </th>").appendTo("#EditProducts");
    } else {
        // Add products to edit list
        for (var i = 0; i < EditProductsList.length; i++) {
            $("<tr >" + " <th scope=\"row\" style=\"width:215px\">" + EditProductsList[i].ProductName + "</th>" +
                "<td style=\"width:85px\">" + EditProductsList[i].ProductStock + "</td>" +
                "<td><input " +
                "id =\"ProductStock" + i + "\"" +
                "class=\" form-control formStyle\"" +
                "style= \"margin-left:60px; width:88px; text-align:center\"" +
                "type=\"number\"" +
                "min=\"0\"" +
                "value=\"0\"" +
                "placeholder=\"Unidades\"></td>" +
                "<td><button type=\"button\" onclick=\"RemoveProductFromEditInventory(" + i + ")\" class=\"btn btn-sm btn-outline-danger\"> x </button> </td>" +
                "</tr>").appendTo("#EditProducts");
        }
    }
}

// Check if Edit Products List contains a certain product
function EditProductsContains(SearchProduct) {
    // Loop throught the List
    for (var i = 0; i < EditProductsList.length; i++) {
        if (EditProductsList[i].Id == SearchProduct.Id) {
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
            // Assign values to the edit product modal
            $("#ProductId").val("");
            $("#ProductName").val("");
            $("#ProductPrice").val("");
            $("#ProductCost").val("");
            $("#ProductStock").attr("placeholder", "Unidades iniciales del producto");
            $("#ProductStockTitle").text("Inventario inicial");
            $("#ProductStock").val("");
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
        url: "/Inventory/GetLatestStockInOut",
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        // If the request is successfull
        success: function (Response) {

            // Set to an array the latest entries of stock in out
            LatestStockInOut = Array.from(JSON.parse(Response));

            // Add products to edit list
            for (var i = 0; i < LatestStockInOut.length; i++) {
               
                if (LatestStockInOut[i].InOrOut == "In") {
                    InOut[i] = "Entrada";
                } else {
                    InOut[i] = "Salida";
                }
                $("<tr> <th scope=\"row\"class=\"tableSizeExtra\">" + i + "</th>" +
                    "<td class=\"tableSize\">" + LatestStockInOut[i].StockInOutDate + "</td>" +
                    "<td class=\"tableSize\">" + LatestStockInOut[i].TotalPrice + "</td>" +
                    "<td class=\"tableSize\">" + LatestStockInOut[i].ClientCC + "</td>" +
                    "<td class=\"tableSize\">" + InOut[i] + "</td>" +
                    "<td><button type=\"button\" onclick=\"StockInOutDetails(" + i + ")\" class=\"btn btn-sm btn-outline-primary\"> Detalles </button> </td>" +
                    "</tr>").appendTo("#StockInOutList");
            }
        }
    });
}



