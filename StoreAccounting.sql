
/****** Object:  Database [StoreAccounting]    Script Date: 16.04.2021 14:55:44 ******/
CREATE DATABASE [StoreAccounting2]
 USE StoreAccounting2
CREATE TABLE [dbo].[CardType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cardtape] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CardType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 16.04.2021 14:55:44 ******/
INSERT INTO[CardType] (cardtape) VALUES ('Visa')
INSERT INTO[CardType] (cardtape) VALUES ('Mastercard')
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Telephone] [int] NOT NULL,
	[idCardType] [int] NOT NULL,
	[CardNumber] [int] NOT NULL,
	[idClientPerson] [int] NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ClientPerson]    Script Date: 16.04.2021 14:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientPerson](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Person] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ClientPerson] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO[ClientPerson] (Person) VALUES ('Физическое')
INSERT INTO[ClientPerson] (Person) VALUES ('Юридическое')

/****** Object:  Table [dbo].[LoadCategory]    Script Date: 16.04.2021 14:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoadCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoadCategory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO[LoadCategory] (CategoryName) VALUES ('Бытовая техника')
INSERT INTO[LoadCategory] (CategoryName) VALUES ('Компьютеры')
INSERT INTO[LoadCategory] (CategoryName) VALUES ('Телефоны')
INSERT INTO[LoadCategory] (CategoryName) VALUES ('Электроника и фото')
/****** Object:  Table [dbo].[PaymentForm]    Script Date: 16.04.2021 14:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentForm](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Form] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PaymentForm] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO[PaymentForm] (Form) VALUES ('Наличные')
INSERT INTO[PaymentForm] (Form) VALUES ('Карта')
/****** Object:  Table [dbo].[Products]    Script Date: 16.04.2021 14:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCategory] [int] NOT NULL,
	[Model] [nvarchar](max) NOT NULL,
	[Manufacturer] [nvarchar](max) NOT NULL,
	[ManufacturerAddress] [nvarchar](max) NOT NULL,
	[Price] [int] NOT NULL,
	[QuantityStore] [int] NOT NULL,
	[QuantityWarehouse] [int] NOT NULL,
	[NameProducts] [nvarchar](max) NOT NULL,
	[SerialNumber] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 16.04.2021 14:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseQuantity] [int] NOT NULL,
	[totalCost] [int] NOT NULL,
	[DeliveryAddress] [nvarchar](max) NOT NULL,
	[idProducts] [int] NOT NULL,
	[idClient] [int] NOT NULL,
	[idPaymentForm] [int] NOT NULL,
	[idSupply] [int] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supply]    Script Date: 16.04.2021 14:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supply](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NameSupply] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Supply] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
INSERT INTO[Supply] (NameSupply) VALUES ('Магазин')
INSERT INTO[Supply] (NameSupply) VALUES ('Склад')
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_CardType] FOREIGN KEY([idCardType])
REFERENCES [dbo].[CardType] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_CardType]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientPerson] FOREIGN KEY([idClientPerson])
REFERENCES [dbo].[ClientPerson] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_ClientPerson]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_LoadCategory] FOREIGN KEY([idCategory])
REFERENCES [dbo].[LoadCategory] ([id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_LoadCategory]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Client] FOREIGN KEY([idClient])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Client]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_PaymentForm] FOREIGN KEY([idPaymentForm])
REFERENCES [dbo].[PaymentForm] ([id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_PaymentForm]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Products] FOREIGN KEY([idProducts])
REFERENCES [dbo].[Products] ([id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Products]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Supply] FOREIGN KEY([idSupply])
REFERENCES [dbo].[Supply] ([id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Supply]
GO
USE [master]
GO

