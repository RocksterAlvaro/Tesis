-- Testing
--EXEC dbo.SPGetSearchProduct @SearchString = 'Per';

/* Stored Procedures */

/* Edit products by my own products table */
CREATE PROCEDURE SPAddOrDeleteStock
	@NewStockProductsTable AS AspNetProductsType READONLY,
	@AddOrDelete nvarchar(250)
AS
BEGIN

	-- DECLARE @v XML = (SELECT * FROM @AddOrDeleteProductsTable FOR XML AUTO)

	IF @AddOrDelete = 'Add'
		UPDATE [AspNetProducts]
		SET [AspNetProducts].[ProductStock] += [@NewStockProductsTable].ProductStock
		FROM
			@NewStockProductsTable
		WHERE [@NewStockProductsTable].Id = [AspNetProducts].Id
		
	ELSE
		UPDATE [AspNetProducts]
		SET [AspNetProducts].[ProductStock] -= [@NewStockProductsTable].ProductStock
		FROM
			@NewStockProductsTable
		WHERE [AspNetProducts].Id = [@NewStockProductsTable].Id
	
		--INSERT XXXX
	
END
GO

/* Get products by products table */
CREATE PROCEDURE SPGetProducts
	@NewStockProductsTable AS AspNetProductsType READONLY
AS
BEGIN
	SELECT [AspNetProducts].* FROM AspNetProducts
	INNER JOIN @NewStockProductsTable
	ON AspNetProducts.Id = [@NewStockProductsTable].Id
END
GO

/* Get products by search string */
CREATE PROCEDURE SPGetSearchProduct
	@SearchString nvarchar(250)
AS
BEGIN
	SELECT * FROM AspNetProducts
	WHERE CHARINDEX(@SearchString, AspNetProducts.ProductName) > 0
END
GO