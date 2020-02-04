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
		
		DECLARE @AspNetStockInOutId VARCHAR(36) = NEWID();

		INSERT INTO [AspNetStockInOut]
		VALUES
		(
			@AspNetStockInOutId, -- Id
			'UserX', -- UserId
			'20/20/20', -- Date
			'In/Out', -- InOrOut
			'Stock/Sale', -- StockOrSale
			'TotalPrice (0)', -- TotalPrice
			'Cedula' -- ClientCC
		);

		INSERT INTO [AspNetProductsList]
		VALUES
		(
			
		)

		--INSERT XXXX
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