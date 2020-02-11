// Global variables
var InOrOutRadioBtn = "In";
var SearchApprovedBool = true;
var SearchProductsList = [];
var EditProductsList = [];

function StockZero() {
    // Make the AJAX request to make every product stock zero
    $.ajax({
        type: "GET",
        url: "/Inventory/StockZero",
        dataType: "json",
        // If the request is successfull
        success: function () {

            // Close the modal
            CloseModal();

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

        console.log("Old value: ", EditProductsList[i].ProductStock, typeof (EditProductsList[i].ProductStock));
        console.log("New value: ", NewProductStock, typeof (NewProductStock));

        if ((InOrOutRadioBtn == "Out" &&
            EditProductsList[i].ProductStock < NewProductStock) ||
            (!Number.isInteger(NewProductStock) ||
                NewProductStock <= -1 ||
                NewProductStock > 1000000000)
        ) {
            console.log("I got invalid values around!");
            ValidNewStock = false;
            break;
        }

        // Update the stock value of teh edit products by the user input
        EditProductsList[i].ProductStock = parseInt($(NewProductStockId).val());
    }


    if (ValidNewStock) {
        SaveStock(InOrOutRadioBtn);
    } else {
        OpenInvalidValuesModal();
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

            //console.log(response);

            EditProductsList = Array.from(JSON.parse(response));

            //console.log(EditProductsList);

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
                        $("<th scope=\"row\"><td colspan=\"3\"  style=\"height: 43vh\"> Ningun producto coincide con la busqueda</td> </th>").appendTo(SearchProducts);
                    }
                }
            });
        } else {
            // Clear Search Products List
            $(SearchProducts).empty();

            // Show the user haven't search anything
            $("<th scope=\"row\"><td colspan=\"3\" style=\"height: 43vh\"> Ninguna busqueda realizada</td> </th>").appendTo(SearchProducts);
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

    // Clear Search Products List
    $(SearchProducts).empty();

    // Fill the list with the products returned by the server
    for (var i = 0; i < SearchProductsList.length; i++) {
        // If the Product is not being edit yet
        if (!EditProductsContains(SearchProductsList[i])) {
            $("<tr >" + " <th scope=\"row\">" + SearchProductsList[i].ProductName + "</th>" +
                "<td class=\"text-center\">" + SearchProductsList[i].ProductPrice + "</td>" +
                "<td class=\"text-center\">" + SearchProductsList[i].ProductStock + "</td>" +
                "<td><button type=\"button\" onclick=\"AddProductToEditInventory(" + i + ")\" class=\"btn btn-sm btn-outline-success\"> > </button> </td>" +
                "</tr>").appendTo(SearchProducts);



            //Products table from Products Main Page
           /* $("<tr >" + " <th scope=\"row\">" + SearchProductsList[i].ProductName + "</th>" +
                "<td class=\"text-center\">" + SearchProductsList[i].ProductPrice + "</td>" +
                "<td class=\"text-center\">" + SearchProductsList[i].ProductStock + "</td>" +
                "<td style=\"color:red\">Detalles</td>" +
                "<td style=\"color:red\">Modificar</td>" +
                "<td style=\"color:red\">Eliminar</td>" +
                "</tr>").appendTo(SearchProducts);*/

            //Old inventory products list
                /*"<li id=\"SearchProduct" + i + "\" class=\"p-2 list-group-item\">" +
                "<div class=\"d-flex justify-content-between\">" +
                "<p class=\"col-4 my-auto\">" + SearchProductsList[i].ProductName + "</p>" +
                "<p class=\"col-2 my-auto\">" + SearchProductsList[i].ProductStock + "</p>" +
                "<button type=\"button\" onclick=\"AddProductToEditInventory(" + i + ")\" class=\"btn btn-sm btn-outline-success\"> > </button>" +
                "</div > " +
                "</li>").appendTo(SearchProducts);
                */


           

        }
    }

    // Clear Edit Products List HTML
    $(EditProducts).empty();

    // Update Edit Products List
    if (EditProductsList.length == 0) {
        // No product added to edit list
        $("<th scope=\"row\"><td colspan=\"3\" style=\"height: 43vh\"> No se ha añadido ningún producto</td> </th>").appendTo(EditProducts);
    } else {
        // Add products to edit list
        for (var i = 0; i < EditProductsList.length; i++) {
            $("<tr >" + " <th scope=\"row\">" + EditProductsList[i].ProductName + "</th>" +
                "<td class=\"text-center\">" + EditProductsList[i].ProductStock + "</td>" +
                "<td><input " +
                "id =\"ProductStock" + i + "\"" +
                "class=\"col-3 form-control formStyle\"" +
                "style= \"left:80px\""+
                "type=\"number\"" +
                "min=\"0\"" +
                "value=\"0\"" +
                "placeholder=\"Inventario\"></td>" +
                "<td><button type=\"button\" onclick=\"RemoveProductFromEditInventory(" + i + ")\" class=\"btn btn-sm btn-outline-danger\"> x </button> </td>" +
                "</tr>").appendTo(EditProducts);


      

            //Old inventory edit list
               /* "<li id=\"EditProduct" + i + "\"class=\"p-2 list-group-item\">" +
                "<div class=\"d-flex justify-content-between\">" +
                "<p class=\"col-4 my-auto\">" + EditProductsList[i].ProductName + "</p>" +
                "<p class=\"col-2 my-auto\">" + EditProductsList[i].ProductStock + "</p>" +
                "<input " +
                "id =\"ProductStock" + i + "\"" +
                "class=\"col-3 form-control formStyle\"" +
                "type=\"number\"" +
                "min=\"0\"" +
                "value=\"0\"" +
                "placeholder=\"Inventario\">" +
                "<button type=\"button\" onclick=\"RemoveProductFromEditInventory(" + i + ")\" class=\"btn btn-sm btn-outline-danger\"> x </button>" +
                "</div > " +
                "</li>"
            ).appendTo(EditProducts); */



            
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

// Get all modals
var ConfirmationModal = document.getElementById("ConfirmationModal");
var InvalidValuesModal = document.getElementById("InvalidValuesModal");

// When the user clicks stock 0, open the modal
function OpenConfirmationModal() {
    ConfirmationModal.style.display = "block";
}

// When the user try to save invalid stock values, open the modal
function OpenInvalidValuesModal() {
    InvalidValuesModal.style.display = "block";
}

// Function that close the modal
function CloseModal() {
    ConfirmationModal.style.display = "none";
    InvalidValuesModal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == ConfirmationModal) {
        ConfirmationModal.style.display = "none";
    }
}

function SearchApproved() {

    // Deny search
    SearchApprovedBool = false;

    setTimeout(function () {

        // Delay next search for 1/10 second
        SearchApprovedBool = true;
    }, 100);
}