USE [master]
GO
/****** Object:  Database [QLRCP_1]    Script Date: 8/1/2025 11:45:07 ******/
CREATE DATABASE [QLRCP_1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLRCP_1', FILENAME = N'D:\SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\QLRCP_1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLRCP_1_log', FILENAME = N'D:\SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\QLRCP_1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLRCP_1] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLRCP_1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLRCP_1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLRCP_1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLRCP_1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLRCP_1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLRCP_1] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLRCP_1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLRCP_1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLRCP_1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLRCP_1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLRCP_1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLRCP_1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLRCP_1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLRCP_1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLRCP_1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLRCP_1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLRCP_1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLRCP_1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLRCP_1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLRCP_1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLRCP_1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLRCP_1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLRCP_1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLRCP_1] SET RECOVERY FULL 
GO
ALTER DATABASE [QLRCP_1] SET  MULTI_USER 
GO
ALTER DATABASE [QLRCP_1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLRCP_1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLRCP_1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLRCP_1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLRCP_1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLRCP_1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLRCP_1', N'ON'
GO
ALTER DATABASE [QLRCP_1] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLRCP_1] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLRCP_1]
GO
/****** Object:  Table [dbo].[buy_tickets]    Script Date: 8/1/2025 11:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buy_tickets](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[movie_id] [varchar](20) NOT NULL,
	[seat_number] [int] NOT NULL,
	[purchase_date] [datetime] NULL,
	[totalPrice] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movies]    Script Date: 8/1/2025 11:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[movie_id] [varchar](20) NOT NULL,
	[movie_name] [nvarchar](100) NOT NULL,
	[genre] [nvarchar](50) NOT NULL,
	[price] [decimal](10, 2) NOT NULL,
	[capacity] [int] NOT NULL,
	[movie_image] [varchar](255) NULL,
	[status] [varchar](20) NOT NULL,
	[created_at] [datetime] NULL,
	[update_date] [datetime] NULL,
	[delete_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_film]    Script Date: 8/1/2025 11:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_film](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[ticket_id] [int] NOT NULL,
	[seat_number] [int] NOT NULL,
	[purchase_date] [datetime] NULL,
	[status] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 8/1/2025 11:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[role] [varchar](20) NOT NULL,
	[status] [varchar](20) NOT NULL,
	[date_reg] [datetime] NULL,
	[update_date] [datetime] NULL,
	[delete_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[buy_tickets] ON 

INSERT [dbo].[buy_tickets] ([id], [user_id], [movie_id], [seat_number], [purchase_date], [totalPrice]) VALUES (1, 12, N'mv3', 43, CAST(N'2025-01-07T21:03:44.767' AS DateTime), 120000)
INSERT [dbo].[buy_tickets] ([id], [user_id], [movie_id], [seat_number], [purchase_date], [totalPrice]) VALUES (2, 12, N'mv3', 25, CAST(N'2025-01-07T21:03:50.057' AS DateTime), 100000)
INSERT [dbo].[buy_tickets] ([id], [user_id], [movie_id], [seat_number], [purchase_date], [totalPrice]) VALUES (3, 12, N'mv5', 42, CAST(N'2025-01-07T22:32:43.303' AS DateTime), 215000)
INSERT [dbo].[buy_tickets] ([id], [user_id], [movie_id], [seat_number], [purchase_date], [totalPrice]) VALUES (4, 12, N'mv5', 38, CAST(N'2025-01-07T22:32:48.330' AS DateTime), 205000)
INSERT [dbo].[buy_tickets] ([id], [user_id], [movie_id], [seat_number], [purchase_date], [totalPrice]) VALUES (5, 12, N'mv2', 44, CAST(N'2025-01-07T22:33:38.537' AS DateTime), 254000)
INSERT [dbo].[buy_tickets] ([id], [user_id], [movie_id], [seat_number], [purchase_date], [totalPrice]) VALUES (6, 12, N'mv3', 32, CAST(N'2025-01-07T23:12:53.740' AS DateTime), 142500)
INSERT [dbo].[buy_tickets] ([id], [user_id], [movie_id], [seat_number], [purchase_date], [totalPrice]) VALUES (7, 12, N'mv3', 23, CAST(N'2025-01-07T23:12:54.053' AS DateTime), 142500)
SET IDENTITY_INSERT [dbo].[buy_tickets] OFF
GO
SET IDENTITY_INSERT [dbo].[movies] ON 

INSERT [dbo].[movies] ([id], [movie_id], [movie_name], [genre], [price], [capacity], [movie_image], [status], [created_at], [update_date], [delete_date]) VALUES (2, N'mg_12312', N'htrh', N'hgj', CAST(768.00 AS Decimal(10, 2)), 600, NULL, N'Deleted', CAST(N'2025-01-05T20:50:57.473' AS DateTime), NULL, CAST(N'2025-01-05T21:19:32.290' AS DateTime))
INSERT [dbo].[movies] ([id], [movie_id], [movie_name], [genre], [price], [capacity], [movie_image], [status], [created_at], [update_date], [delete_date]) VALUES (3, N'mv', N'54yhgfjjjjjj', N'iyuiyhhh', CAST(690.00 AS Decimal(10, 2)), 666, NULL, N'Deleted', CAST(N'2025-01-05T21:20:17.303' AS DateTime), NULL, CAST(N'2025-01-05T22:20:30.750' AS DateTime))
INSERT [dbo].[movies] ([id], [movie_id], [movie_name], [genre], [price], [capacity], [movie_image], [status], [created_at], [update_date], [delete_date]) VALUES (4, N'mv2', N'helo', N'hanh dong', CAST(49000.00 AS Decimal(10, 2)), 400, N'C:\Users\Admin\Downloads\Avengers_Endgame_bia_teaser.jpg', N'Co san', CAST(N'2025-01-05T22:20:50.183' AS DateTime), NULL, NULL)
INSERT [dbo].[movies] ([id], [movie_id], [movie_name], [genre], [price], [capacity], [movie_image], [status], [created_at], [update_date], [delete_date]) VALUES (5, N'mv3', N'averga', N'hai huoc', CAST(30000.00 AS Decimal(10, 2)), 200, N'C:\Users\Admin\Downloads\images (1).jpg', N'Co san', CAST(N'2025-01-05T23:37:00.297' AS DateTime), NULL, NULL)
INSERT [dbo].[movies] ([id], [movie_id], [movie_name], [genre], [price], [capacity], [movie_image], [status], [created_at], [update_date], [delete_date]) VALUES (6, N'mv5', N'titanic', N'kinh di', CAST(50000.00 AS Decimal(10, 2)), 100, N'C:\Users\Admin\Downloads\Titanic_3D_poster_Vietnam.jpg', N'Co san', CAST(N'2025-01-07T14:49:08.407' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[movies] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (1, N'admin', N'admin123', N'Admin', N'active', CAST(N'2025-01-05T15:11:31.240' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (3, N'hoai', N'hoai123', N'member', N'active', CAST(N'2025-01-05T22:25:55.220' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (6, N'kiet', N'kiet1234', N'Staff', N'active', CAST(N'2025-01-05T23:12:53.010' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (7, N'kiet2', N'kiet1234', N'Staff', N'active', CAST(N'2025-01-05T23:20:31.313' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (8, N'dat', N'dat123', N'Staff', N'Deleted', CAST(N'2025-01-06T23:22:36.787' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (9, N'cuong', N'cuong123', N'member', N'active', CAST(N'2025-01-07T12:46:30.827' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (11, N'anh', N'anh123', N'member', N'Active', CAST(N'2025-01-07T14:13:44.057' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (12, N'do', N'3e120e960cafc29d10348c7a5303d5cc2027c0971cdac251198ae79d75906af3', N'member', N'Active', CAST(N'2025-01-07T14:15:46.450' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (13, N'hoai1', N'ddf459459d1ac918ae8c1392ebf0433ef5bb136cdb79ce8097c36bf328198009', N'Admin', N'Active', CAST(N'2025-01-07T14:23:28.263' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (14, N'dat1', N'ad273572f4afba8725890ff70e97fc83a84ade01d4fe8104c5ecd54d3a12a127', N'member', N'Active', CAST(N'2025-01-07T23:13:32.237' AS DateTime), NULL, NULL)
INSERT [dbo].[users] ([id], [username], [password], [role], [status], [date_reg], [update_date], [delete_date]) VALUES (15, N'dat2', N'46f4eda71b571aecedc1a623533c7abe7cfbf7bfae8d5ec694eb6cb6fd7eadd9', N'member', N'Active', CAST(N'2025-01-07T23:40:47.137' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__movies__83CDF748AD8669D6]    Script Date: 8/1/2025 11:45:07 ******/
ALTER TABLE [dbo].[movies] ADD UNIQUE NONCLUSTERED 
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Movies_Status]    Script Date: 8/1/2025 11:45:07 ******/
CREATE NONCLUSTERED INDEX [IX_Movies_Status] ON [dbo].[movies]
(
	[status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__users__F3DBC572E9D01162]    Script Date: 8/1/2025 11:45:07 ******/
ALTER TABLE [dbo].[users] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_Role]    Script Date: 8/1/2025 11:45:07 ******/
CREATE NONCLUSTERED INDEX [IX_Users_Role] ON [dbo].[users]
(
	[role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_Username]    Script Date: 8/1/2025 11:45:07 ******/
CREATE NONCLUSTERED INDEX [IX_Users_Username] ON [dbo].[users]
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[buy_tickets] ADD  DEFAULT (getdate()) FOR [purchase_date]
GO
ALTER TABLE [dbo].[buy_tickets] ADD  DEFAULT ((0)) FOR [totalPrice]
GO
ALTER TABLE [dbo].[movies] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[user_film] ADD  DEFAULT (getdate()) FOR [purchase_date]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ('active') FOR [status]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (getdate()) FOR [date_reg]
GO
ALTER TABLE [dbo].[buy_tickets]  WITH CHECK ADD FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([movie_id])
GO
ALTER TABLE [dbo].[buy_tickets]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[user_film]  WITH CHECK ADD FOREIGN KEY([ticket_id])
REFERENCES [dbo].[buy_tickets] ([id])
GO
ALTER TABLE [dbo].[user_film]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[movies]  WITH CHECK ADD CHECK  (([status]='Deleted' OR [status]='Het' OR [status]='Co san'))
GO
ALTER TABLE [dbo].[user_film]  WITH CHECK ADD CHECK  (([status]='Cancelled' OR [status]='Watched' OR [status]='Booked'))
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD CHECK  (([role]='member' OR [role]='Staff' OR [role]='Admin'))
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD CHECK  (([status]='Deleted' OR [status]='inactive' OR [status]='active'))
GO
USE [master]
GO
ALTER DATABASE [QLRCP_1] SET  READ_WRITE 
GO
