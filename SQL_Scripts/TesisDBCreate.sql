/* Create TesisDB */
USE [master]
GO

IF DB_ID('TesisDB') IS NOT NULL
DROP DATABASE TesisDB;
GO

/****** Object:  Database [TesisDB]    Script Date: 18/04/2019 12:46:43 p. m. ******/
CREATE DATABASE [TesisDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TesisDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TesisDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TesisDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TesisDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

/* Use TesisDB as [dbo] */
USE [TesisDB]
GO

-- BEGIN TRANSACTION
-- ROLLBACK

/* Create Tables */

/* Create table AspNetUser */
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](36) NOT NULL,
	[FirstNames] [nvarchar](256) NULL,
	[LastNames] [nvarchar](256) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/* Create table type AspNetProducts */
CREATE TYPE AspNetProductsType
AS TABLE(
	[Id] [nvarchar](36) NOT NULL,
	[ProductName] [nvarchar] (256) NULL,
	[ProductStock] [int] NULL,
	[ProductPrice] [int] NULL,
	[ProductCost] [int] NULL
);
GO

/* Create table AspNetProducts */
CREATE TABLE [dbo].[AspNetProducts](
	[Id] [nvarchar](36) NOT NULL,
	[ProductName] [nvarchar] (256) NULL,
	[ProductStock] [int] NULL,
	[ProductPrice] [int] NULL,
	[ProductCost] [int] NULL,
 CONSTRAINT [PK_AspNetProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* Create table AspNetStockInOut */
CREATE TABLE [dbo].[AspNetStockInOut](
	[Id] [nvarchar](36) NOT NULL,
	[UserId] [nvarchar](36) NOT NULL,
	[Date] [nvarchar] (50) NULL,
	[InOrOut] [nvarchar] (50) NULL,
	[StockOrSale] [nvarchar] (50) NULL,
	[TotalPrice] [int] NULL,
	[ClientCC] [int] NULL,
 CONSTRAINT [PK_AspNetStockInOut] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* Create table AspNetProductsList */
CREATE TABLE [dbo].[AspNetProductsList](
	[ProductId] [nvarchar](36) NOT NULL,
	[StockChange] [int] NULL,
	[StockInOutId] [nvarchar] (36) NOT NULL,
 CONSTRAINT [PK_AspNetProductsList] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[StockInOutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* Create table AspNetHistoricPrices */
CREATE TABLE [dbo].[AspNetHistoricPrices](
	[Id] [nvarchar](36) NOT NULL,
	[StartDate] [nvarchar](256) NULL,
	[EndDate] [nvarchar](256) NULL,
	[CurrentPrice] [bit] NULL,
 CONSTRAINT [PK_AspNetHistoricPrices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* Create table AspNetRoleClaims */
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](36) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/* Create table AspNetRoles */
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](36) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/* Create table AspNetUserClaims */
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](36) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/* Create table AspNetUserLogins */
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](36) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/* Create table AspNetUserRoles */
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](36) NOT NULL,
	[RoleId] [nvarchar](36) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* Create table AspNetUserTokens */
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](36) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/* Create AspNetProductsList foreign keys */
ALTER TABLE [dbo].[AspNetProductsList]
WITH CHECK ADD  CONSTRAINT [FK_AspNetProductsList_AspNetProducts_ProductId]
FOREIGN KEY([ProductId])
REFERENCES [dbo].[AspNetProducts] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetProductsList] CHECK CONSTRAINT [FK_AspNetProductsList_AspNetProducts_ProductId]
GO

ALTER TABLE [dbo].[AspNetProductsList]
WITH CHECK ADD  CONSTRAINT [FK_AspNetProductsList_AspNetStockInOut_StockInOutId]
FOREIGN KEY([StockInOutId])
REFERENCES [dbo].[AspNetStockInOut] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetProductsList] CHECK CONSTRAINT [FK_AspNetProductsList_AspNetStockInOut_StockInOutId]
GO

/* Create AspNetStockInOut foreign keys */
ALTER TABLE [dbo].[AspNetStockInOut]  WITH CHECK ADD  CONSTRAINT [FK_AspNetStockInOut_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetStockInOut] CHECK CONSTRAINT [FK_AspNetStockInOut_AspNetUsers_UserId]
GO

/* Create AspNetRoles foreign keys */
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO

/* Create AspNetUserClaims foreign keys */
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO

/* Create AspNetUserLogins foreign keys */
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO

/* Create AspNetUserRoles foreign keys */
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO

ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO

/* Create AspNetUserTokens foreign keys */
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO