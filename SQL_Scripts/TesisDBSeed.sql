-- Add Super User
INSERT INTO AspNetUsers
VALUES
(
	-- Alvaro Super User
	'989D4C70-1A43-4411-9CDC-4DDF5709C74C', -- [Id]
	'Alvaro Steveen', -- [FirstNames]
	'Lopez Abril', -- [LastNames]
	'RocksterAlvaro', --[UserName]
	'ROCKSTERALVARO', -- [NormalizedUserName] [nvarchar](256) NULL,
	'rocksteralvaro@gmail.com', -- [Email] [nvarchar](256) NULL,
	'ROCKSTERALVARO@GMAIL.COM', -- [NormalizedEmail] [nvarchar](256) NULL,
	1, -- EmailConfirmed
	'x', -- PasswordHash
	NEWID(), -- SecurityStamp 
	NEWID(), -- ConcurrencyStamp
	'3177552828', -- PhoneNumber
	1, -- PhoneNumberConfirmed
	0, -- TwoFactorEnabled
	NULL, -- LockoutEnd
	1, -- LockoutEnabled
	0 -- AccessFailedCount
),
(
	-- Alvaro Super User
	'989D4C70-1A43-4411-9DDC-4DDF5709C74C', -- [Id]
	'Nicolas Andres', -- [FirstNames]
	'Bernal Davila', -- [LastNames]
	'DarkDust', --[UserName]
	'DARKDUST', -- [NormalizedUserName] [nvarchar](256) NULL,
	'nbernal783@unab.edu.co', -- [Email] [nvarchar](256) NULL,
	'NBERNAL783@UNAB.EDU.CO', -- [NormalizedEmail] [nvarchar](256) NULL,
	1, -- EmailConfirmed
	'x', -- PasswordHash
	NEWID(), -- SecurityStamp 
	NEWID(), -- ConcurrencyStamp
	'3023478988', -- PhoneNumber
	1, -- PhoneNumberConfirmed
	0, -- TwoFactorEnabled
	NULL, -- LockoutEnd
	1, -- LockoutEnabled
	0 -- AccessFailedCount
);

-- Add Roles
INSERT INTO AspNetRoles
VALUES
(
	-- Alvaro Super User
	'd8453449-26f4-4db5-accc-ad2e8d7d641a', --[Id]
	'Admin', -- [Name]
	'ADMIN', -- [NormalizedName]
	'382d0c6b-d40a-4e91-b082-122af5a77071' -- [ConcurrencyStamp]
),
(
	-- Alvaro Super User
	'e3e9f9a5-bd98-4ba9-b1f2-3d190a2b7751', --[Id]
	'ShopAdmin', -- [Name]
	'SHOPADMIN', -- [NormalizedName]
	'f7a60c20-5041-476b-b1ca-30a0d94944e9' -- [ConcurrencyStamp]
),
(
	-- Alvaro Super User
	'a2696a90-53f0-414f-8e11-5d8958a16558', --[Id]
	'Seller', -- [Name]
	'SELLER', -- [NormalizedName]
	'b6bf1d8f-1753-431d-8cab-6b6e95153e90' -- [ConcurrencyStamp]
);

-- Add Super User
INSERT INTO AspNetUserRoles
VALUES
(
	'989D4C70-1A43-4411-9CDC-4DDF5709C74C', -- [UserId]
	'd8453449-26f4-4db5-accc-ad2e8d7d641a' -- [RoleId]
);

-- Adds Products
INSERT INTO AspNetProducts
VALUES
(
-- Add 'Manzana Verde'
	'18b7c42b-5929-4cb8-9c26-be49472a2934', -- ID
	'Manzana Verde', -- ProductName
	20, -- ProductStock
	1500, -- ProductPrice
	700, -- ProductCost
	1 -- ProductActive
),
(
-- Add 'Manzana Roja'
	'd0cad872-1373-4709-8874-4a0526a93fcd', -- ID
	'Manzana Roja', -- ProductName
	10, -- ProductStock
	1300, -- ProductPrice
	500, -- ProductCost
	1 -- ProductActive
),
(
-- Add 'Pera'
	'7cb20609-8113-4715-ac1e-d5b2c63b6601', -- ID
	'Pera', -- ProductName
	50, -- ProductStock
	75, -- ProductPrice
	50, -- ProductCost
	1 -- ProductActive
),
(
-- Add 'Naranja'
	'ad26e714-eaf6-40de-88fb-78314bebf9cc', -- ID
	'Naranja', -- ProductName
	35, -- ProductStock
	50, -- ProductPrice
	25, -- ProductCost
	1 -- ProductActive
),
(
-- Add 'Papa'
	'84d446f0-bc55-41c2-b91b-6523e5ed20ab', -- ID
	'Papa', -- ProductName
	56, -- ProductStock
	110, -- ProductPrice
	80, -- ProductCost
	1 -- ProductActive
),
(
-- Add 'Zanahoria'
	'bdff9107-9625-4c9f-a7c5-3e07724bb54f', -- ID
	'Zanahoria', -- ProductName
	72, -- ProductStock
	120, -- ProductPrice
	100, -- ProductCost
	1 -- ProductActive
),
(
-- Add 'Cebolla'
	'163b9c50-0043-4aff-9f54-edbaab63a5f3', -- ID
	'Cebolla', -- ProductName
	84, -- ProductStock
	135, -- ProductPrice
	95, -- ProductCost
	1 -- ProductActive
);

/*
-- Adds StockInOut Movemements
INSERT INTO AspNetStockInOut
VALUES
(
-- Add # Movement
	NEWID(), -- ID
	'989D4C70-1A43-4411-9CDC-4DDF5709C74C', -- UserID
	'04/04/2020', -- Date
	'Out', -- InOrOut
	'Sale', -- StockOrSale
	400, -- TotalPrice
	80421514-- ClienCC
);

-- Adds Products List
INSERT INTO AspNetProductsList
VALUES
(
-- Add Product to the List
	AnyProduct, -- ProductID
	15, -- StockChange
	SameAsAbove -- StockInOutId
);
*/