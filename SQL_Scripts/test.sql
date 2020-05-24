-- 1
DECLARE @AspNetStockInOutId VARCHAR(36) = NEWID();

PRINT @AspNetStockInOutId

INSERT INTO [AspNetStockInOut]
VALUES
(
	@AspNetStockInOutId, -- Id
	'989D4C70-1A43-4411-9CDC-4DDF5709C74C', -- UserId
	FORMAT(GETDATE(), 'dd/MM/yyyy'), -- Date
	'In', -- InOrOut
	'Stock', -- StockOrSale
	0, -- TotalPrice - (0)
	80421514 -- ClientCC - Cedula
);