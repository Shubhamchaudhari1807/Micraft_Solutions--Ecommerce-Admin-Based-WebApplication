USE [Db_Micraft]
GO
/****** Object:  Table [dbo].[m_Contact_Us]    Script Date: 13-03-2024 10:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_Contact_Us](
	[cust_id] [int] IDENTITY(1,1) NOT NULL,
	[Full_Name] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Customer_Message] [nvarchar](50) NULL,
	[attribute1] [nvarchar](50) NULL,
 CONSTRAINT [PK_m_Contact_Us] PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_Customer]    Script Date: 13-03-2024 10:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_Customer](
	[Customer_Id] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Name] [nvarchar](50) NULL,
	[Customer_Address] [nvarchar](max) NULL,
	[Customer_City] [nvarchar](max) NULL,
	[Pin_Code] [int] NULL,
 CONSTRAINT [PK_m_Customer] PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_Order]    Script Date: 13-03-2024 10:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_Order](
	[Order_Id] [int] IDENTITY(1,1) NOT NULL,
	[Order_Date] [datetime] NULL,
	[Customer_Id] [int] NULL,
	[Total_Qty] [nvarchar](50) NULL,
	[Total_Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_m_Order] PRIMARY KEY CLUSTERED 
(
	[Order_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_Product]    Script Date: 13-03-2024 10:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_Product](
	[Product_Id] [int] IDENTITY(1,1) NOT NULL,
	[Product_Code] [nvarchar](50) NULL,
	[Product_Name] [nvarchar](50) NULL,
	[Product_Image] [nvarchar](max) NULL,
	[Product_Unit] [nvarchar](50) NULL,
	[Product_Rate] [decimal](18, 0) NULL,
	[Product_Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_m_Product] PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_register]    Script Date: 13-03-2024 10:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_register](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_name] [nvarchar](50) NULL,
	[email_id] [nvarchar](50) NULL,
	[contact_no] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[customer_address] [nvarchar](50) NULL,
 CONSTRAINT [PK_m_register] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_line_order]    Script Date: 13-03-2024 10:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_line_order](
	[Line_ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductCode] [int] NULL,
 CONSTRAINT [PK_t_line_order] PRIMARY KEY CLUSTERED 
(
	[Line_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_order]    Script Date: 13-03-2024 10:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_order](
	[Order_id] [int] IDENTITY(1,1) NOT NULL,
	[order_amount] [decimal](18, 2) NULL,
	[order_qty] [decimal](18, 2) NULL,
	[customer_name] [nvarchar](50) NULL,
	[customer_address] [nvarchar](50) NULL,
	[customer_contact] [nvarchar](50) NULL,
	[order_rate] [decimal](18, 2) NULL,
	[attr1] [nvarchar](50) NULL,
	[attr2] [nvarchar](50) NULL,
	[attr3] [nvarchar](50) NULL,
	[order_date] [datetime] NULL,
 CONSTRAINT [PK_t_order] PRIMARY KEY CLUSTERED 
(
	[Order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Table]    Script Date: 13-03-2024 10:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Table](
	[User_id] [int] IDENTITY(1,1) NOT NULL,
	[User_Name] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_User_Table] PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[m_Contact_Us] ON 
GO
INSERT [dbo].[m_Contact_Us] ([cust_id], [Full_Name], [Email], [Customer_Message], [attribute1]) VALUES (1, N'Nandlal Patil', N'nt@gmail.com', N'Best Product ', N'YES')
GO
INSERT [dbo].[m_Contact_Us] ([cust_id], [Full_Name], [Email], [Customer_Message], [attribute1]) VALUES (2, N'dinesh patil', N'dk@gmail.com', N'nice Product', N'yes')
GO
INSERT [dbo].[m_Contact_Us] ([cust_id], [Full_Name], [Email], [Customer_Message], [attribute1]) VALUES (1002, N'nikhil patil', N'dineshpatil1082000@gmail.com', N'hii', N'YES')
GO
SET IDENTITY_INSERT [dbo].[m_Contact_Us] OFF
GO
SET IDENTITY_INSERT [dbo].[m_Customer] ON 
GO
INSERT [dbo].[m_Customer] ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_City], [Pin_Code]) VALUES (1, N'Nikhil Salunkhe', N'Hinjewadi', N'Pune', 410052)
GO
INSERT [dbo].[m_Customer] ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_City], [Pin_Code]) VALUES (2, N'Sakhashi Patil', N'Dhule', N'Dhule', 425405)
GO
INSERT [dbo].[m_Customer] ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_City], [Pin_Code]) VALUES (3, N'Nandlal Thakare', N'Surat', N'surat', 425008)
GO
INSERT [dbo].[m_Customer] ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_City], [Pin_Code]) VALUES (4, N'Mangesh Patil', N'Shingave Shivar', N'Shirpur', 425405)
GO
INSERT [dbo].[m_Customer] ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_City], [Pin_Code]) VALUES (5, N'Dinesh Patil', N'Chopda', N'Chopada', 410021)
GO
INSERT [dbo].[m_Customer] ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_City], [Pin_Code]) VALUES (6, N'Vishanavi Patil', N'Nashik', N'Nashik', 425403)
GO
INSERT [dbo].[m_Customer] ([Customer_Id], [Customer_Name], [Customer_Address], [Customer_City], [Pin_Code]) VALUES (7, N'Akash Jadhav', N'Shindkheda', N'Dhule', 425406)
GO
SET IDENTITY_INSERT [dbo].[m_Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[m_Order] ON 
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (1, CAST(N'2022-01-29T00:00:00.000' AS DateTime), 1, N'2', CAST(1 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (2, CAST(N'2022-01-30T00:00:00.000' AS DateTime), 3, N'22', CAST(12 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (3, CAST(N'2022-01-27T00:00:00.000' AS DateTime), 1234, N'543', CAST(234 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (4, CAST(N'2022-01-31T00:00:00.000' AS DateTime), 1, NULL, CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (5, CAST(N'2022-01-31T00:00:00.000' AS DateTime), 2, NULL, CAST(2 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (6, CAST(N'2022-01-25T00:00:00.000' AS DateTime), 4, NULL, CAST(44 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (7, CAST(N'2022-01-29T00:00:00.000' AS DateTime), 4, NULL, CAST(543 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (8, CAST(N'2022-01-31T00:00:00.000' AS DateTime), 2, NULL, CAST(44 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (9, CAST(N'2022-01-31T00:00:00.000' AS DateTime), 2, N'44', NULL)
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (10, CAST(N'2022-01-31T00:00:00.000' AS DateTime), 2, N'1', NULL)
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (11, CAST(N'2022-01-13T00:00:00.000' AS DateTime), 3, N'22', CAST(200 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (12, CAST(N'2022-01-31T00:00:00.000' AS DateTime), 0, N'3.00', CAST(5400 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (13, CAST(N'2022-01-31T00:00:00.000' AS DateTime), 0, N'3.00', CAST(10010 AS Decimal(18, 0)))
GO
INSERT [dbo].[m_Order] ([Order_Id], [Order_Date], [Customer_Id], [Total_Qty], [Total_Amount]) VALUES (14, CAST(N'2022-01-30T00:00:00.000' AS DateTime), 5, N'12.00', CAST(10050 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[m_Order] OFF
GO
SET IDENTITY_INSERT [dbo].[m_Product] ON 
GO
INSERT [dbo].[m_Product] ([Product_Id], [Product_Code], [Product_Name], [Product_Image], [Product_Unit], [Product_Rate], [Product_Description]) VALUES (1, N'D101', N'Desktop', N'~/SaveImage/Desktop221647985.jpg', N'No', CAST(25000 AS Decimal(18, 0)), N'I3 Desktop PC')
GO
INSERT [dbo].[m_Product] ([Product_Id], [Product_Code], [Product_Name], [Product_Image], [Product_Unit], [Product_Rate], [Product_Description]) VALUES (2, N'B231', N'Boll', N'~/SaveImage/Boll221747130.jpg', N'No', CAST(100 AS Decimal(18, 0)), N'Good Quality Boll')
GO
INSERT [dbo].[m_Product] ([Product_Id], [Product_Code], [Product_Name], [Product_Image], [Product_Unit], [Product_Rate], [Product_Description]) VALUES (3, N'K432', N'keyboard', N'~/SaveImage/keyboard221900973.jpg', N'Number', CAST(300 AS Decimal(18, 0)), N'USB keyboard')
GO
INSERT [dbo].[m_Product] ([Product_Id], [Product_Code], [Product_Name], [Product_Image], [Product_Unit], [Product_Rate], [Product_Description]) VALUES (4, N'L1316', N'Laptop', N'~/SaveImage/Laptop222011256.jpg', N'Number', CAST(15000 AS Decimal(18, 0)), N'i5 10 Gen Laptop')
GO
INSERT [dbo].[m_Product] ([Product_Id], [Product_Code], [Product_Name], [Product_Image], [Product_Unit], [Product_Rate], [Product_Description]) VALUES (5, N'M456', N'Mobile', N'~/SaveImage/Mobile222146150.jpg', N'No', CAST(40000 AS Decimal(18, 0)), N'ISO Mobile')
GO
INSERT [dbo].[m_Product] ([Product_Id], [Product_Code], [Product_Name], [Product_Image], [Product_Unit], [Product_Rate], [Product_Description]) VALUES (6, N'M435', N'Mouse', N'~/SaveImage/Mouse222242705.jpg', N'Number', CAST(50 AS Decimal(18, 0)), N'USb Mouse')
GO
INSERT [dbo].[m_Product] ([Product_Id], [Product_Code], [Product_Name], [Product_Image], [Product_Unit], [Product_Rate], [Product_Description]) VALUES (7, N'W765', N'Watch', N'~/SaveImage/Watch222338471.jpg', N'Number', CAST(3421 AS Decimal(18, 0)), N'Watch is Good Quality ')
GO
INSERT [dbo].[m_Product] ([Product_Id], [Product_Code], [Product_Name], [Product_Image], [Product_Unit], [Product_Rate], [Product_Description]) VALUES (8, N'003', N'T-Shirt', N'~/SaveImage/OIP (2)223639474244050957.jpg', N'10', CAST(499 AS Decimal(18, 0)), N'Think about how you could make the customer feel a part of the brand')
GO
INSERT [dbo].[m_Product] ([Product_Id], [Product_Code], [Product_Name], [Product_Image], [Product_Unit], [Product_Rate], [Product_Description]) VALUES (9, N'003', N'T-Shirt', N'~/SaveImage/WhatsApp Image 2024-02-14 at 11.245157965.jpg', N'10', CAST(499 AS Decimal(18, 0)), N'QWEFGHJ,.')
GO
SET IDENTITY_INSERT [dbo].[m_Product] OFF
GO
SET IDENTITY_INSERT [dbo].[m_register] ON 
GO
INSERT [dbo].[m_register] ([customer_id], [customer_name], [email_id], [contact_no], [password], [customer_address]) VALUES (1002, N'Nikhil', N'nik@123', N'98675847', N'1234567', N'dhule')
GO
INSERT [dbo].[m_register] ([customer_id], [customer_name], [email_id], [contact_no], [password], [customer_address]) VALUES (1003, N'Nikhil', N'nik@123', N'98675847', N'1234567', N'dhule')
GO
SET IDENTITY_INSERT [dbo].[m_register] OFF
GO
SET IDENTITY_INSERT [dbo].[t_line_order] ON 
GO
INSERT [dbo].[t_line_order] ([Line_ID], [OrderID], [ProductCode]) VALUES (12, 27, 2)
GO
SET IDENTITY_INSERT [dbo].[t_line_order] OFF
GO
SET IDENTITY_INSERT [dbo].[t_order] ON 
GO
INSERT [dbo].[t_order] ([Order_id], [order_amount], [order_qty], [customer_name], [customer_address], [customer_contact], [order_rate], [attr1], [attr2], [attr3], [order_date]) VALUES (1, CAST(50000.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), N'Nandlal Patil', N'Shirprur', N'9370229581', CAST(25000.00 AS Decimal(18, 2)), N'Desktop', NULL, NULL, CAST(N'2024-02-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[t_order] ([Order_id], [order_amount], [order_qty], [customer_name], [customer_address], [customer_contact], [order_rate], [attr1], [attr2], [attr3], [order_date]) VALUES (2, CAST(2000000.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), N'Nandlal Patil', N'Shirprur', N'9370229581', CAST(25000.00 AS Decimal(18, 2)), N'Desktop', NULL, NULL, CAST(N'2024-02-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[t_order] ([Order_id], [order_amount], [order_qty], [customer_name], [customer_address], [customer_contact], [order_rate], [attr1], [attr2], [attr3], [order_date]) VALUES (3, CAST(2000000.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), N'Nandlal Patil', N'Shirprur', N'9370229581', CAST(25000.00 AS Decimal(18, 2)), N'Desktop', NULL, NULL, CAST(N'2024-02-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[t_order] ([Order_id], [order_amount], [order_qty], [customer_name], [customer_address], [customer_contact], [order_rate], [attr1], [attr2], [attr3], [order_date]) VALUES (4, CAST(25000.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'Darshan', N'Shirpur', N'7058171572', CAST(25000.00 AS Decimal(18, 2)), N'Desktop', NULL, NULL, CAST(N'2024-02-12T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[t_order] OFF
GO
SET IDENTITY_INSERT [dbo].[User_Table] ON 
GO
INSERT [dbo].[User_Table] ([User_id], [User_Name], [Password]) VALUES (1, N'nt002', N'nt1416')
GO
SET IDENTITY_INSERT [dbo].[User_Table] OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_fb_Result]    Script Date: 13-03-2024 10:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_fb_Result]
as 
begin
   Select cust_id,Full_Name,Email,Customer_Message,attribute1
   from m_Contact_Us
   end
GO
/****** Object:  StoredProcedure [dbo].[sp_feedback_Result]    Script Date: 13-03-2024 10:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[sp_feedback_Result]
as 
begin
   Select cust_id,Full_Name,Email,Customer_Message,attribute1
   from m_Contact_Us
   end


GO
/****** Object:  StoredProcedure [dbo].[Sp_m_Customer]    Script Date: 13-03-2024 10:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_m_Customer]
as
begin
select * from m_Customer
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_m_Product_Report]    Script Date: 13-03-2024 10:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_m_Product_Report]
as
begin
 select Product_Id,
Product_Code,
Product_Name,
Product_Image,
Product_Unit,
Product_Rate,
Product_Description

from m_Product
end


select * from m_Product
GO
/****** Object:  StoredProcedure [dbo].[Sp_m_t_order_Result]    Script Date: 13-03-2024 10:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[Sp_m_t_order_Result]
as 
begin 
   select Order_id,order_amount,order_qty,
   customer_name,customer_address,customer_contact,order_rate,
   attr1
   from t_order 
   end
GO
