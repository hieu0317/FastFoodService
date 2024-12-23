USE [master]
GO
/****** Object:  Database [PRN231_ProjectMain]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE DATABASE [PRN231_ProjectMain]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRN231_ProjectMain', FILENAME = N'/var/opt/mssql/data/PRN231_ProjectMain.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRN231_ProjectMain_log', FILENAME = N'/var/opt/mssql/data/PRN231_ProjectMain_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PRN231_ProjectMain] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRN231_ProjectMain].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRN231_ProjectMain] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRN231_ProjectMain] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRN231_ProjectMain] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PRN231_ProjectMain] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRN231_ProjectMain] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [PRN231_ProjectMain] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET RECOVERY FULL 
GO
ALTER DATABASE [PRN231_ProjectMain] SET  MULTI_USER 
GO
ALTER DATABASE [PRN231_ProjectMain] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRN231_ProjectMain] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRN231_ProjectMain] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRN231_ProjectMain] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRN231_ProjectMain] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PRN231_ProjectMain] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PRN231_ProjectMain', N'ON'
GO
ALTER DATABASE [PRN231_ProjectMain] SET QUERY_STORE = OFF
GO
USE [PRN231_ProjectMain]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
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
	[Address] [nvarchar](max) NOT NULL,
	[Fullname] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
	[RoleId] [int] NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[BlogId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[BlogTitle] [nvarchar](max) NULL,
	[BlogDetail] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
	[Status] [bit] NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[BlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartDetails]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartDetails](
	[CartId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_CartDetails] PRIMARY KEY CLUSTERED 
(
	[CartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
	[Describe] [nvarchar](max) NULL,
	[CatImage] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Likes]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Likes](
	[LikeId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Likes] PRIMARY KEY CLUSTERED 
(
	[LikeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderInfos]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfos](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_OrderInfos] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[Total] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Note] [nvarchar](max) NULL,
	[OrderStatusId] [int] NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[PaymentMethod] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatuses]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatuses](
	[OrderStatusId] [int] IDENTITY(1,1) NOT NULL,
	[OrderStatusName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_OrderStatuses] PRIMARY KEY CLUSTERED 
(
	[OrderStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[Details] [nvarchar](max) NULL,
	[Price] [int] NOT NULL,
	[Status] [bit] NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/23/2024 2:24:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720074956_initial', N'6.0.32')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720082256_ver2', N'6.0.32')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720134614_ver3', N'6.0.32')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720160416_ver4', N'6.0.32')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240720175457_ver5', N'6.0.32')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241221090832_finalVer', N'6.0.32')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address], [Fullname], [Status], [RoleId]) VALUES (N'0309bf86-8458-4995-b8ad-92ec0e3cd020', N'hieuhieuhieu', N'HIEUHIEUHIEU', N'minh@gmail.com', N'MINH@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHHOObVEq9kK4fJvxfL9jtonsqxS9fny627pn5ceymRXm7RkbGiTtm6ZPbu1UoTWyQ==', N'QTL3HOKDUJXV5F44V4ZQQHXV3IXA23TQ', N'd2930161-7a05-41d7-adc3-d053b0c43b05', N'0334940472', 0, 0, NULL, 1, 0, N'số 2 ,ngõ 1, thôn 3, đường cây xăng 39, Thạch Hòa, Thạch Thất, Hà Nội', N'Hiếu Vũ Minh', 1, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Address], [Fullname], [Status], [RoleId]) VALUES (N'f12fa2ca-8bdd-4580-a9b5-9429a6383960', N'hieu123', N'HIEU123', N'vuminhhieu171103@gmail.com', N'VUMINHHIEU171103@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEO8nCCpjqlC3QYm5CmmNUe9oUpMys32g+Z33rJuv9VM8AE3Bsviv1VMf92oOVdeSgA==', N'JBVUEDCPQNMPO3NLGNUMUSMXF7AX3AMB', N'fc6f1948-75c1-4f33-a115-b61d3cead894', N'0334940472', 0, 0, NULL, 1, 0, N'số 2 ,ngõ 1, thôn 3, đường cây xăng 39, Thạch Hòa, Thạch Thất, Hà Nội', N'Hiếu Vũ Minh', 1, NULL)
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Describe], [CatImage]) VALUES (1, N'Snack', NULL, N'images/category/snack.jpg')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Describe], [CatImage]) VALUES (2, N'Dessert-Drink', NULL, N'images/category/dessert.jpg')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Describe], [CatImage]) VALUES (3, N'Spaghetti', NULL, N'images/category/MY-Y-POP.jpg')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Describe], [CatImage]) VALUES (4, N'Rice', NULL, N'images/category/Rice-F.Chicken.jpg')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Describe], [CatImage]) VALUES (5, N'Burger', NULL, N'images/category/burger.jpg')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Describe], [CatImage]) VALUES (6, N'Chicken', NULL, N'images/category/Fried-Chicken.jpg')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Describe], [CatImage]) VALUES (7, N'Combo', NULL, N'images/category/c-gahoangkim.jpg')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderStatuses] ON 

INSERT [dbo].[OrderStatuses] ([OrderStatusId], [OrderStatusName]) VALUES (1, N'Preparing')
INSERT [dbo].[OrderStatuses] ([OrderStatusId], [OrderStatusName]) VALUES (2, N'Deliverying')
INSERT [dbo].[OrderStatuses] ([OrderStatusId], [OrderStatusName]) VALUES (3, N'Delivered')
INSERT [dbo].[OrderStatuses] ([OrderStatusId], [OrderStatusName]) VALUES (4, N'Fail to delivery')
INSERT [dbo].[OrderStatuses] ([OrderStatusId], [OrderStatusName]) VALUES (5, N'Is canceled')
SET IDENTITY_INSERT [dbo].[OrderStatuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (1, 6, N'Fried Chicken', NULL, 36000, 1, N'images/chicken/fried-chicken/Fried-Chicken.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (2, 6, N'Roasted Fillet', NULL, 39000, 1, N'images/chicken/rosted-chicken/MOD-PHI-LE-GA-QUAY.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (3, 6, N'ROASTED CHICKEN LEG QUARTER', NULL, 75000, 1, N'images/chicken/rosted-chicken/luon-ga.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (4, 5, N'Burger Flava', NULL, 55000, 1, N'images/burger/Burger-Flava.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (5, 5, N'Burger Shrimp', NULL, 45000, 1, N'images/burger/Burger-Shrimp.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (6, 5, N'Burger Zinger', NULL, 55000, 1, N'images/burger/Burger-Zinger.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (7, 4, N'Fried Chicken Rice', NULL, 46000, 1, N'images/rice/Rice-F.Chicken.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (8, 4, N'Flava Rice', NULL, 46000, 1, N'images/rice/Rice-Flava.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (9, 4, N'Steak Rice', NULL, 46000, 1, N'images/rice/Rice-Steak.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (10, 4, N'Tenderods Rice', NULL, 46000, 1, N'images/rice/Rice-TENDERODS.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (11, 4, N'Skewer Rice', NULL, 46000, 1, N'images/rice/Rice-Skewer.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (12, 3, N'Spaghetti ', NULL, 41000, 1, N'images/spaghetti/MY-Y-POP.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (13, 1, N'Seaweed Soup', NULL, 17000, 1, N'images/snack/Soup-Rong-Bien.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (14, 1, N'Coleslaw', NULL, 12000, 1, N'images/snack/BapCai-Tron.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (15, 1, N'Mashed Potato', NULL, 12000, 1, N'images/snack/KhoaiTay-Nghien.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (16, 1, N'French Fries', NULL, 19000, 1, N'images/snack/KhoaiTay-Chien.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (17, 1, N'Salad Pop', NULL, 39000, 1, N'images/snack/SALAD-HAT-GA-VIEN.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (18, 1, N'Salad Hat', NULL, 36000, 1, N'images/snack/SALAD-HAT.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (19, 2, N'Peach Tea', NULL, 24000, 1, N'images/dessert-drink/Peach-Tea.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (20, 2, N'Lipton Lemon Tea', NULL, 10000, 1, N'images/dessert-drink/Lipton.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (21, 2, N'Pepsi Black Lime Can', NULL, 17000, 1, N'images/dessert-drink/pepsi-lime-can.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (22, 2, N'Aquafina 500ml', NULL, 15000, 1, N'images/dessert-drink/Aquafina-500ml.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (23, 2, N'7Up Can', NULL, 17000, 1, N'images/dessert-drink/7Up-Can.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (24, 2, N'Pepsi Can', NULL, 17000, 1, N'images/dessert-drink/Pepsi-Can.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (25, 2, N'Pumcheese', NULL, 15000, 1, N'images/dessert-drink/Pumcheese.jpg')
INSERT [dbo].[Products] ([ProductId], [CategoryId], [ProductName], [Details], [Price], [Status], [ImageUrl]) VALUES (26, 2, N'Eggtart', NULL, 18000, 1, N'images/dessert-drink/eggtart.jpg')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (1, N'CUSTOMER')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (2, N'Admin')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (3, N'Sale')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (4, N'MKT')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUsers_RoleId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUsers_RoleId] ON [dbo].[AspNetUsers]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Blogs_UserId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Blogs_UserId] ON [dbo].[Blogs]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CartDetails_ProductId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_CartDetails_ProductId] ON [dbo].[CartDetails]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CartDetails_UserId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_CartDetails_UserId] ON [dbo].[CartDetails]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Likes_ProductId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Likes_ProductId] ON [dbo].[Likes]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Likes_UserId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Likes_UserId] ON [dbo].[Likes]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderInfos_ProductId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderInfos_ProductId] ON [dbo].[OrderInfos]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_OrderStatusId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_OrderStatusId] ON [dbo].[Orders]
(
	[OrderStatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Orders_UserId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_UserId] ON [dbo].[Orders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 12/23/2024 2:24:33 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [Address]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [Fullname]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Status]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
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
ALTER TABLE [dbo].[AspNetUsers]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUsers_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
ALTER TABLE [dbo].[AspNetUsers] CHECK CONSTRAINT [FK_AspNetUsers_Roles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[CartDetails]  WITH CHECK ADD  CONSTRAINT [FK_CartDetails_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CartDetails] CHECK CONSTRAINT [FK_CartDetails_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[CartDetails]  WITH CHECK ADD  CONSTRAINT [FK_CartDetails_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CartDetails] CHECK CONSTRAINT [FK_CartDetails_Products_ProductId]
GO
ALTER TABLE [dbo].[Likes]  WITH CHECK ADD  CONSTRAINT [FK_Likes_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Likes] CHECK CONSTRAINT [FK_Likes_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Likes]  WITH CHECK ADD  CONSTRAINT [FK_Likes_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[Likes] CHECK CONSTRAINT [FK_Likes_Products_ProductId]
GO
ALTER TABLE [dbo].[OrderInfos]  WITH CHECK ADD  CONSTRAINT [FK_OrderInfos_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderInfos] CHECK CONSTRAINT [FK_OrderInfos_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderInfos]  WITH CHECK ADD  CONSTRAINT [FK_OrderInfos_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderInfos] CHECK CONSTRAINT [FK_OrderInfos_Products_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_OrderStatuses_OrderStatusId] FOREIGN KEY([OrderStatusId])
REFERENCES [dbo].[OrderStatuses] ([OrderStatusId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_OrderStatuses_OrderStatusId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
USE [master]
GO
ALTER DATABASE [PRN231_ProjectMain] SET  READ_WRITE 
GO
