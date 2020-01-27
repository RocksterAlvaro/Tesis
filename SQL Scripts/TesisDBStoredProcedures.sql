-- Testing
--EXEC dbo.SPGetSearchProduct @SearchString = 'Per';

/* Stored Procedures */

/* Get all the Enterprises */
CREATE PROCEDURE SPGetSearchProduct
	@SearchString nvarchar(250)
AS
BEGIN
	SELECT * FROM AspNetProducts
	WHERE CHARINDEX(@SearchString, AspNetProducts.ProductName) > 0   
	--CONTAINS(AspNetProducts.ProductName ,@SearchString)
END
GO