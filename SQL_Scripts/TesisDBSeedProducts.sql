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
);

-- Adds Products
INSERT INTO AspNetProducts
VALUES
(
-- Add 'Manzana Verde'
	'18b7c42b-5929-4cb8-9c26-be49472a2934', -- ID
	'Manzana Verde', -- ProductName
	20, -- ProductStock
	200 -- ProductPrice
),
(
-- Add 'Manzana Roja'
	'd0cad872-1373-4709-8874-4a0526a93fcd', -- ID
	'Manzana Roja', -- ProductName
	10, -- ProductStock
	150 -- ProductPrice
),
(
-- Add 'Pera'
	'7cb20609-8113-4715-ac1e-d5b2c63b6601', -- ID
	'Pera', -- ProductName
	50, -- ProductStock
	75 -- ProductPrice
),
(
-- Add 'Naranja'
	'ad26e714-eaf6-40de-88fb-78314bebf9cc', -- ID
	'Naranja', -- ProductName
	35, -- ProductStock
	50 -- ProductPrice
),
(
-- Add 'Papa'
	'84d446f0-bc55-41c2-b91b-6523e5ed20ab', -- ID
	'Papa', -- ProductName
	56, -- ProductStock
	110 -- ProductPrice
),
(
-- Add 'Zanahoria'
	'bdff9107-9625-4c9f-a7c5-3e07724bb54f', -- ID
	'Zanahoria', -- ProductName
	72, -- ProductStock
	120 -- ProductPrice
),
(
-- Add 'Cebolla'
	'163b9c50-0043-4aff-9f54-edbaab63a5f3', -- ID
	'Cebolla', -- ProductName
	84, -- ProductStock
	135 -- ProductPrice
);