// Global variables
var InOrOutRadioBtn = "In";
var SearchApprovedBool = true;
var SearchProductsList = [];
var EditProductsList = [];
var PageTitle = document.title.slice(0, -8);

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
        $(SearchProducts).empty();

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
                        $(SearchProducts).empty();

                        // No product returned by the server
                        $("<th scope=\"row\"><td colspan=\"3\"  style=\"height: 43vh\"> Ningún producto coincide con la busqueda </td> </th>").appendTo(SearchProducts);
                    }
                }
            });
        } else {
            // Clear Search Products List
            $(SearchProducts).empty();

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
    SearchProduct($(SearchBar).val());
}

function RemoveProductFromEditInventory(ProductIndex) {
    // Remove the product from the list of editing products
    EditProductsList.splice(ProductIndex, 1);

    // Update Lists
    SearchProduct($(SearchBar).val());
}

// Update Lists
function UpdateLists() {

    //console.log("Old title: ", document.title;
    //console.log("New title: ", string);

    // Clear Search Products List
    $(SearchProducts).empty();

    switch (PageTitle) {
        // Products page
        case 'Products':
            UpdateProductsLists();

            break;
        // Inventory movements page
        case 'InventoryMovement':

            // Clear Edit Products List HTML
            $(EditProducts).empty();

            // Update lists
            UpdateInventoryMovementLists()

            break;

        // Default - Probably error
        default:
            console.log("Error");
            // Crear modal de error.
    }
}

// Inventory movement update lists
function UpdateProductsLists() {
    // Fill the list with the products returned by the server
    for (var i = 0; i < SearchProductsList.length; i++) {
        // If the Product is not being edit yet
        if (!EditProductsContains(SearchProductsList[i])) {
            $("<tr >" + " <th scope=\"row\" style=\"width:235px\">" + SearchProductsList[i].ProductName + "</th>" +
                "<td style=\"width:160px\">" + SearchProductsList[i].ProductPrice + "</td>" +
                "<td style=\"width:80px\">" + SearchProductsList[i].ProductStock + "</td>" +
                "<td><button type=\"button\" onclick=\"EditProduct(" + i + ")\" class=\"btn btn-sm btn-outline-primary\"> Editar </button> </td>" +
                "<td><button type=\"button\" onclick=\"DeleteProduct(" + i + ")\" class=\"btn btn-sm btn-outline-danger\"> Eliminar </button> </td>" +
                "</tr>").appendTo(SearchProducts);
        }
    }
}

// Inventory movement update lists
function UpdateInventoryMovementLists() {

    // Fill the list with the products returned by the server
    for (var i = 0; i < SearchProductsList.length; i++) {
        // If the Product is not being edit yet
        if (!EditProductsContains(SearchProductsList[i])) {
            $("<tr >" + " <th scope=\"row\" style=\"width:235px\">" + SearchProductsList[i].ProductName + "</th>" +
                "<td style=\"width:160px\">" + SearchProductsList[i].ProductPrice + "</td>" +
                "<td style=\"width:80px\">" + SearchProductsList[i].ProductStock + "</td>" +
                "<td><button type=\"button\" onclick=\"AddProductToEditInventory(" + i + ")\" class=\"btn btn-sm btn-outline-success\"> > </button> </td>" +
                "</tr>").appendTo(SearchProducts);
        }
    }
    
    // Update Edit Products List
    if (EditProductsList.length == 0) {
        // No product added to edit list
        $("<th scope=\"row\"><td colspan=\"3\" style=\"height: 43vh\"> No se ha añadido ningún producto</td> </th>").appendTo(EditProducts);
    } else {
        // Add products to edit list
        for (var i = 0; i < EditProductsList.length; i++) {
            $("<tr >" + " <th scope=\"row\" style=\"width:215px\">" + EditProductsList[i].ProductName + "</th>" +
                "<td style=\"width:85px\">" + EditProductsList[i].ProductStock + "</td>" +
                "<td><input " +
                "id =\"ProductStock" + i + "\"" +
                "class=\"col-3 form-control formStyle\"" +
                "style= \"left:80px\"" +
                "type=\"number\"" +
                "min=\"0\"" +
                "value=\"0\"" +
                "placeholder=\"Inventario\"></td>" +
                "<td><button type=\"button\" onclick=\"RemoveProductFromEditInventory(" + i + ")\" class=\"btn btn-sm btn-outline-danger\"> x </button> </td>" +
                "</tr>").appendTo(EditProducts);
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