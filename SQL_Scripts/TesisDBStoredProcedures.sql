-- Testing
/*
Declare @ProductsToPredictTable AS AspNetProductsType;
Declare @DateToPredict AS nvarchar(256) = '04/04/2020';

INSERT INTO @ProductsToPredictTable
	SELECT TOP 1 *
	FROM AspNetProducts
	WHERE AspNetProducts.Id = '18b7c42b-5929-4cb8-9c26-be49472a2934';

--SELECT * FROM @ProductsToPredictTable;

EXEC dbo.SPPreviousSoldProducts
	@ProductsToPredictTable,
	@DateToPredict;
*/

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


-- Get previous sold products
CREATE PROCEDURE SPPreviousSoldProducts
	@ProductsToPredictTable AS AspNetProductsType READONLY,
	@DateToPredict AS nvarchar(250)
AS
BEGIN
	SELECT
		[AspNetProducts].Id,
		[AspNetProducts].ProductName,
		[AspNetStockInOut].StockInOutDate,
		[AspNetProductsList].[StockChange]
	FROM [AspNetProducts]
	INNER JOIN @ProductsToPredictTable
		ON [AspNetProducts].Id = [@ProductsToPredictTable].Id
	INNER JOIN [AspNetProductsList]
			ON [@ProductsToPredictTable].Id =  [AspNetProductsList].ProductId
	INNER JOIN [AspNetStockInOut]
		ON [AspNetProductsList].StockInOutId = [AspNetStockInOut].Id AND
			[AspNetStockInOut].StockOrSale = 'Sale' AND
			[AspNetStockInOut].InOrOut = 'Out' AND
			SUBSTRING([AspNetStockInOut].[StockInOutDate], 1, 2) = SUBSTRING(@DateToPredict, 1, 2) AND
			CONVERT(DATETIME,[AspNetStockInOut].[StockInOutDate], 103) <= CONVERT(DATETIME, @DateToPredict, 103) AND
			CONVERT(DATETIME,[AspNetStockInOut].[StockInOutDate], 103) > DateAdd(Month, -12, CONVERT(DATETIME, @DateToPredict, 103))
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
	@StockOrSale nvarchar(50),
	@TotalPrice int
AS
BEGIN
	DECLARE @AspNetStockInOutId VARCHAR(36) = NEWID();

	-- If the table products sum
	IF @StockOrSale = 'Stock'
		INSERT INTO [AspNetStockInOut]
		VALUES
		(
			@AspNetStockInOutId, -- Id
			'989D4C70-1A43-4411-9CDC-4DDF5709C74C', -- UserId
			FORMAT(GETDATE(), 'dd/MM/yyyy'), -- StockInOutDate
			@InOrOut, -- InOrOut
			@StockOrSale, -- StockOrSale
			0, -- TotalPrice - (0)
			80421514 -- ClientCC - Cedula
		);
	ELSE
		INSERT INTO [AspNetStockInOut]
		VALUES
		(
			@AspNetStockInOutId, -- Id
			'989D4C70-1A43-4411-9CDC-4DDF5709C74C', -- UserId
			FORMAT(GETDATE(), 'dd/MM/yyyy'), -- StockInOutDate
			@InOrOut, -- InOrOut
			@StockOrSale, -- StockOrSale
			@TotalPrice, -- TotalPrice - (0)
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
	@StockOrSale nvarchar(50),
	@TotalPrice int
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
		@StockOrSale,
		@TotalPrice
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
		'Stock',
		0
END
GO

/* Get latest stock in out movements */
CREATE PROCEDURE SPGetLatestStockInOut
AS
BEGIN
	SELECT TOP 30 * FROM [AspNetStockInOut]
	ORDER BY CONVERT(datetime, [AspNetStockInOut].[StockInOutDate], 103) ASC
END
GO

/* Get specific movement products */
CREATE PROCEDURE SPGetSpecificMovementProducts
	@SpecificMovementId nvarchar(36)
AS
BEGIN
	SELECT
		[AspNetProducts].*,
		[AspNetProductsList].StockChange
	FROM [AspNetProductsList]
	-- WHERE [AspNetProductsList].StockInOutId = @SpecificMovementId
	INNER JOIN [AspNetProducts]
	ON [AspNetProductsList].StockInOutId = @SpecificMovementId AND
		[AspNetProductsList].ProductId = [AspNetProducts].Id
END
GO