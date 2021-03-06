USE [Banking_ApplicationDB]
GO
/****** Object:  Table [dbo].[User_Login]    Script Date: 12/13/2018 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Login](
	[Username] [nvarchar](10) NOT NULL,
	[Password] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Personal_Details]    Script Date: 12/13/2018 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer_Personal_Details](
	[Cust_Acc_No] [numeric](8, 0) NOT NULL,
	[First_Name] [varchar](20) NOT NULL,
	[Middle_Name] [varchar](20) NOT NULL,
	[Surname] [varchar](20) NOT NULL,
	[Mothers_Name] [varchar](20) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[Pin_Code] [numeric](6, 0) NOT NULL,
	[Birth_Date] [date] NOT NULL,
	[Pan_No] [varchar](10) NOT NULL,
	[Addhar_No] [numeric](12, 0) NOT NULL,
	[Phone_No] [numeric](12, 0) NULL,
	[Mob_No] [numeric](10, 0) NOT NULL,
	[Email_Id] [varchar](20) NULL,
 CONSTRAINT [PK_Customer_Personal_Details] PRIMARY KEY CLUSTERED 
(
	[Cust_Acc_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer_Account_Details]    Script Date: 12/13/2018 14:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Account_Details](
	[Cust_Acc_No] [numeric](8, 0) NOT NULL,
	[Cust_Acc_Created_Date] [date] NOT NULL,
	[Cust_Acc_Type] [text] NOT NULL,
	[Cust_Acc_Balance] [numeric](12, 2) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Customer_Account_Details_Customer_Personal_Details]    Script Date: 12/13/2018 14:55:26 ******/
ALTER TABLE [dbo].[Customer_Account_Details]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Account_Details_Customer_Personal_Details] FOREIGN KEY([Cust_Acc_No])
REFERENCES [dbo].[Customer_Personal_Details] ([Cust_Acc_No])
GO
ALTER TABLE [dbo].[Customer_Account_Details] CHECK CONSTRAINT [FK_Customer_Account_Details_Customer_Personal_Details]
GO
