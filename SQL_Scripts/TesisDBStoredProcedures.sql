-- Testing
--EXEC dbo.SPGetSearchProduct @SearchString = 'Per';

/* Stored Procedures */

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
	SELECT TOP 30 * FROM AspNetProducts
	WHERE CHARINDEX(@SearchString, AspNetProducts.ProductName) > 0
END
GO

/* Create a record in StockInOut and records in ProductList, wich represents receipt */
CREATE PROCEDURE SPReceiptGenerator
	@NewStockProductsTable AS AspNetProductsType READONLY,
	@InOrOut nvarchar(50),
	@StockOrSale nvarchar(50)
AS
BEGIN
	DECLARE @AspNetStockInOutId VARCHAR(36) = NEWID();

	INSERT INTO [AspNetStockInOut]
	VALUES
	(
		@AspNetStockInOutId, -- Id
		'989D4C70-1A43-4411-9CDC-4DDF5709C74C', -- UserId
		FORMAT(GETDATE(), 'dd/MM/yyyy'), -- Date
		@InOrOut, -- InOrOut
		@StockOrSale, -- StockOrSale
		0, -- TotalPrice - (0)
		80421514 -- ClientCC - Cedula
	);

	INSERT INTO [AspNetProductsList]
		SELECT [@NewStockProductsTable].Id, [ProductStock], @AspNetStockInOutId
		FROM @NewStockProductsTable
		INNER JOIN [AspNetStockInOut]
			ON [AspNetStockInOut].Id = @AspNetStockInOutId
END
GO

/* Edit products stock */
CREATE PROCEDURE SPInOrOutStock
	@NewStockProductsTable AS AspNetProductsType READONLY, -- Table of edited products
	@InOrOut nvarchar(50),
	@StockOrSale nvarchar(50)
AS
BEGIN
	
	-- If the table products sum
	IF @InOrOut = 'In'
		UPDATE [AspNetProducts]
		SET [AspNetProducts].[ProductStock] += [@NewStockProductsTable].ProductStock
		FROM
			@NewStockProductsTable
		WHERE [@NewStockProductsTable].Id = [AspNetProducts].Id
	-- If the table products subtract
	ELSE
		UPDATE [AspNetProducts]
		SET [AspNetProducts].[ProductStock] -= [@NewStockProductsTable].ProductStock
		FROM
			@NewStockProductsTable
		WHERE [@NewStockProductsTable].Id = [AspNetProducts].Id
	
	-- Create traceability
	EXEC SPReceiptGenerator
		@NewStockProductsTable,
		@InOrOut,
		@StockOrSale
END
GO

CREATE PROCEDURE SPZeroStock
AS
BEGIN
	-- Create products table type
	DECLARE @NewStockProductsTable AS AspNetProductsType;

	-- Copy all products to the table type variable
	INSERT INTO @NewStockProductsTable
	SELECT * FROM [AspNetProducts];

	-- Set every product stock to zero
	UPDATE [AspNetProducts]
	SET [ProductStock] = 0

	-- Create traceability
	EXEC SPReceiptGenerator
		@NewStockProductsTable,
		'Out',
		'Stock'
END
GO