USE [master]
GO
/****** Object:  Database [warehouse]    Script Date: 25.02.2025 16:46:38 Часы ******/
CREATE DATABASE [warehouse]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'warehouse', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\warehouse.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'warehouse_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\warehouse_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [warehouse] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [warehouse].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [warehouse] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [warehouse] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [warehouse] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [warehouse] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [warehouse] SET ARITHABORT OFF 
GO
ALTER DATABASE [warehouse] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [warehouse] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [warehouse] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [warehouse] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [warehouse] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [warehouse] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [warehouse] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [warehouse] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [warehouse] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [warehouse] SET  DISABLE_BROKER 
GO
ALTER DATABASE [warehouse] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [warehouse] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [warehouse] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [warehouse] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [warehouse] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [warehouse] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [warehouse] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [warehouse] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [warehouse] SET  MULTI_USER 
GO
ALTER DATABASE [warehouse] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [warehouse] SET DB_CHAINING OFF 
GO
ALTER DATABASE [warehouse] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [warehouse] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [warehouse] SET DELAYED_DURABILITY = DISABLED 
GO
USE [warehouse]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ContactDetails] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Клиенты] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExpenditureInvoices]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenditureInvoices](
	[ExpenditureInvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [bigint] NULL,
	[ShippingDate] [date] NULL,
	[ClientID] [int] NULL,
	[ProductsList] [nvarchar](50) NULL,
	[TotalAmount] [money] NULL,
 CONSTRAINT [PK_РасходныеНакладные] PRIMARY KEY CLUSTERED 
(
	[ExpenditureInvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IncomingInvoices]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncomingInvoices](
	[IncomingInvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [bigint] NULL,
	[DateReceipt] [date] NULL,
	[SupplierID] [int] NULL,
	[ProductsList] [nvarchar](50) NULL,
	[TotalAmount] [money] NULL,
 CONSTRAINT [PK_ПриходныеНакладные] PRIMARY KEY CLUSTERED 
(
	[IncomingInvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[InventoryID] [int] IDENTITY(1,1) NOT NULL,
	[DateEvent] [date] NULL,
	[Responsible] [nvarchar](50) NULL,
	[Results] [nvarchar](50) NULL,
 CONSTRAINT [PK_Инвентаризация] PRIMARY KEY CLUSTERED 
(
	[InventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Article] [bigint] NULL,
	[Barcode] [varchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[UnitOfMeasurement] [nvarchar](50) NULL,
	[UnitPrice] [money] NULL,
	[SerialNumber] [bigint] NULL,
	[MinBalance] [bigint] NULL,
 CONSTRAINT [PK_Товары] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductsExpenditureInvoices]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsExpenditureInvoices](
	[ProductsExpenditureInvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[ExpenditureInvoiceID] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [bigint] NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_ТоварыВРасходныхНакладных] PRIMARY KEY CLUSTERED 
(
	[ProductsExpenditureInvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductsIncomingInvoices]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsIncomingInvoices](
	[ProductsIncomingInvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[IncomingInvoiceID] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [bigint] NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_ТоварыВПриходныхНакладных] PRIMARY KEY CLUSTERED 
(
	[ProductsIncomingInvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductsInventory]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsInventory](
	[ProductsInventoryID] [int] IDENTITY(1,1) NOT NULL,
	[InventoryID] [int] NULL,
	[ProductID] [int] NULL,
	[ActualQuantity] [bigint] NULL,
	[AccountingQuantity] [bigint] NULL,
 CONSTRAINT [PK_ТоварыВИнвентаризации] PRIMARY KEY CLUSTERED 
(
	[ProductsInventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductsInWarehouses]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsInWarehouses](
	[ProductInWarehouseID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[WarehouseID] [int] NULL,
	[Quantity] [bigint] NULL,
 CONSTRAINT [PK_ProductsInWarehouses] PRIMARY KEY CLUSTERED 
(
	[ProductInWarehouseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[INN] [bigint] NULL,
	[ContactDetails] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Поставщики] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Warehouses]    Script Date: 25.02.2025 16:46:38 Часы ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouses](
	[WarehouseID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[StorageArea] [nvarchar](50) NULL,
 CONSTRAINT [PK_Склады] PRIMARY KEY CLUSTERED 
(
	[WarehouseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ExpenditureInvoices]  WITH CHECK ADD  CONSTRAINT [FK_ExpenditureInvoices_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[ExpenditureInvoices] CHECK CONSTRAINT [FK_ExpenditureInvoices_Clients]
GO
ALTER TABLE [dbo].[IncomingInvoices]  WITH CHECK ADD  CONSTRAINT [FK_IncomingInvoices_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[IncomingInvoices] CHECK CONSTRAINT [FK_IncomingInvoices_Suppliers]
GO
ALTER TABLE [dbo].[ProductsExpenditureInvoices]  WITH CHECK ADD  CONSTRAINT [FK_ProductsExpenditureInvoices_ExpenditureInvoices] FOREIGN KEY([ExpenditureInvoiceID])
REFERENCES [dbo].[ExpenditureInvoices] ([ExpenditureInvoiceID])
GO
ALTER TABLE [dbo].[ProductsExpenditureInvoices] CHECK CONSTRAINT [FK_ProductsExpenditureInvoices_ExpenditureInvoices]
GO
ALTER TABLE [dbo].[ProductsExpenditureInvoices]  WITH CHECK ADD  CONSTRAINT [FK_ProductsExpenditureInvoices_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[ProductsExpenditureInvoices] CHECK CONSTRAINT [FK_ProductsExpenditureInvoices_Products]
GO
ALTER TABLE [dbo].[ProductsIncomingInvoices]  WITH CHECK ADD  CONSTRAINT [FK_ProductsIncomingInvoices_IncomingInvoices] FOREIGN KEY([IncomingInvoiceID])
REFERENCES [dbo].[IncomingInvoices] ([IncomingInvoiceID])
GO
ALTER TABLE [dbo].[ProductsIncomingInvoices] CHECK CONSTRAINT [FK_ProductsIncomingInvoices_IncomingInvoices]
GO
ALTER TABLE [dbo].[ProductsIncomingInvoices]  WITH CHECK ADD  CONSTRAINT [FK_ProductsIncomingInvoices_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[ProductsIncomingInvoices] CHECK CONSTRAINT [FK_ProductsIncomingInvoices_Products]
GO
ALTER TABLE [dbo].[ProductsInventory]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInventory_Inventory] FOREIGN KEY([InventoryID])
REFERENCES [dbo].[Inventory] ([InventoryID])
GO
ALTER TABLE [dbo].[ProductsInventory] CHECK CONSTRAINT [FK_ProductsInventory_Inventory]
GO
ALTER TABLE [dbo].[ProductsInventory]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInventory_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[ProductsInventory] CHECK CONSTRAINT [FK_ProductsInventory_Products]
GO
ALTER TABLE [dbo].[ProductsInWarehouses]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInWarehouses_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[ProductsInWarehouses] CHECK CONSTRAINT [FK_ProductsInWarehouses_Products]
GO
ALTER TABLE [dbo].[ProductsInWarehouses]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInWarehouses_Warehouses] FOREIGN KEY([WarehouseID])
REFERENCES [dbo].[Warehouses] ([WarehouseID])
GO
ALTER TABLE [dbo].[ProductsInWarehouses] CHECK CONSTRAINT [FK_ProductsInWarehouses_Warehouses]
GO
USE [master]
GO
ALTER DATABASE [warehouse] SET  READ_WRITE 
GO
