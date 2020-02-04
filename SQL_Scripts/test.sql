-- 1
DECLARE @p as AspNetProductsType
INSERT @p VALUES
	('18b7c42b-5929-4cb8-9c26-be49472a2934', 'Manzana Verde', 523, 200),
	('XX', 'No existo', 215, 26);

UPDATE [AspNetProducts]
	SET [AspNetProducts].[ProductStock] = [@p].ProductStock
	FROM
		@p
	WHERE [@p].Id = [AspNetProducts].Id

SELECT * FROM AspNetProducts

-- 2
SELECT * FROM @p
INNER JOIN AspNetProducts
ON AspNetProducts.Id = [@p].Id

-- 3
UPDATE AspNetProducts 
SET AspNetProducts.ProductStock = 300;

SELECT * FROM AspNetProducts

-- 4
EXEC [dbo].[SPAddOrDeleteStock] @p
DROP PROC [SPAddOrDeleteStock] 

/*
	UPDATE AspNetProducts 
	SET AspNetProducts.ProductStock = [@AddOrDeleteProductsTable].ProductStock
	WHERE
		AspNetProducts.Id = [@AddOrDeleteProductsTable].Id
	*/

	/*
	UPDATE AspNetProducts 
	SET AspNetProducts.ProductStock =
		(SELECT ProductStock FROM @AddOrDeleteProductsTable
			WHERE AspNetProducts.Id = [@AddOrDeleteProductsTable].Id);
	*/

	/*
	UPDATE [AspNetProducts]
	SET [AspNetProducts].[ProductStock] = [@AddOrDeleteProductsTable].ProductStock
	FROM
		[@AddOrDeleteProductsTable] PT
	WHERE
		PT.Id = [AspNetProducts].Id
	*/