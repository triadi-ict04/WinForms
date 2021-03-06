USE [DB_JT18]
GO
/****** Object:  UserDefinedFunction [dbo].[CUFN_CEK_USER]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[CUFN_CEK_USER]
(
  @USER_PASSWORD varchar(200),
  @USER_USERNAME varchar(200) 
)
RETURNS varchar(200)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @ID varchar(200)

	-- Add the T-SQL statements to compute the return value here
	SELECT        @ID = [USER_RAW_ID]
	FROM            TBL_R_USER
	WHERE        (USER_USERNAME = @USER_USERNAME) AND (USER_PASSWORD = CONVERT(VARCHAR(32), HashBytes('MD5', '' + @USER_PASSWORD), 2))

	-- Return the result of the function
	RETURN @ID

END
GO
/****** Object:  UserDefinedFunction [dbo].[CUFN_GET_TARE_UNIT]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[CUFN_GET_TARE_UNIT] 
(
	@UNIT_NO varchar(10)
)
RETURNS INT
AS
BEGIN
	
DECLARE @TRANS_TARE  int = null
DECLARE @default_TARE  int = null

set @default_TARE = (select [UNIT_DEFAULT_TARE] from [dbo].[TBL_R_UNIT] where [UNIT_NO] = @UNIT_NO  )
set @TRANS_TARE  = (SELECT TOP 1 [TARE_VALUE] FROM [dbo].[TBL_T_TARE_UNIT] WHERE [TARE_DATETIME] <= getdate() AND [TARE_UNIT_NO] = @UNIT_NO ORDER BY [TARE_DATETIME] DESC)

set @TRANS_TARE = isnull(@TRANS_TARE,@default_TARE)

return @TRANS_TARE

END
GO
/****** Object:  Table [dbo].[TBL_R_MENU]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_R_MENU](
	[Primer] [bigint] NOT NULL,
	[Id] [int] NOT NULL,
	[Menu] [nvarchar](50) NOT NULL,
	[Menu_link] [int] NULL,
	[Link] [nvarchar](1000) NULL,
	[Urutan] [int] NULL,
	[Deskripsi] [varchar](250) NULL,
	[style_class] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_R_MENU] PRIMARY KEY CLUSTERED 
(
	[Primer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_R_MENU_LOGIN]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_R_MENU_LOGIN](
	[Menu_primer] [varchar](10) NOT NULL,
	[User_level] [varchar](1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_R_MENU_LOGIN]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_R_MENU_LOGIN]
AS
SELECT LO.Menu_primer, LO.User_level, MN.Id, MN.Menu, MN.Menu_link, MN.Link, MN.Urutan, MN.Deskripsi, MN.style_class
FROM   dbo.TBL_R_MENU_LOGIN AS LO LEFT OUTER JOIN
           dbo.TBL_R_MENU AS MN ON LO.Menu_primer = MN.Primer
GO
/****** Object:  Table [dbo].[TBL_M_AKSES]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_M_AKSES](
	[AKSES_RAW_ID] [varchar](200) NOT NULL,
	[AKSES_NAME] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TBL_M_AKSES] PRIMARY KEY CLUSTERED 
(
	[AKSES_RAW_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_R_USER]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_R_USER](
	[USER_RAW_ID] [varchar](200) NOT NULL,
	[USER_NAME] [varchar](200) NOT NULL,
	[USER_COMPANY] [varchar](50) NOT NULL,
	[USER_AKSES] [varchar](200) NOT NULL,
	[USER_USERNAME] [varchar](10) NOT NULL,
	[USER_PASSWORD] [varchar](200) NOT NULL,
 CONSTRAINT [PK_TBL_R_USER] PRIMARY KEY CLUSTERED 
(
	[USER_RAW_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_R_USER]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_R_USER]
AS
SELECT usr.USER_RAW_ID, usr.USER_NAME, usr.USER_COMPANY, usr.USER_AKSES, aks.AKSES_NAME, usr.USER_USERNAME, usr.USER_PASSWORD
FROM   dbo.TBL_R_USER AS usr LEFT OUTER JOIN
           dbo.TBL_M_AKSES AS aks ON usr.USER_AKSES = aks.AKSES_RAW_ID
GO
/****** Object:  Table [dbo].[TBL_R_UNIT]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_R_UNIT](
	[UNIT_NO] [varchar](10) NOT NULL,
	[UNIT_ENTITY] [varchar](5) NOT NULL,
	[UNIT_EGI] [varchar](10) NOT NULL,
	[UNIT_KONTRAKTOR] [varchar](10) NOT NULL,
	[UNIT_DEFAULT_TARE] [int] NOT NULL,
	[UNIT_AKTIF] [varchar](1) NOT NULL,
 CONSTRAINT [PK_TBL_R_UNIT] PRIMARY KEY CLUSTERED 
(
	[UNIT_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_T_TARE_UNIT]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_T_TARE_UNIT](
	[TARE_RAW_ID] [varchar](200) NOT NULL,
	[TARE_UNIT_NO] [varchar](20) NOT NULL,
	[TARE_VALUE] [int] NOT NULL,
	[TARE_DATETIME] [datetime] NOT NULL,
 CONSTRAINT [PK_TBL_T_TARE_UNIT] PRIMARY KEY CLUSTERED 
(
	[TARE_RAW_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_T_MAX_TARE]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VW_T_MAX_TARE]
AS
select 
tr.NUMBER,
tr.TARE_RAW_ID,
tr.TARE_UNIT_NO,
un.UNIT_NO,
tr.TARE_DATETIME,
isnull(tr.TARE_VALUE, un.UNIT_DEFAULT_TARE) as TARE_VALUE
from  [dbo].[TBL_R_UNIT] un
left join 
(
SELECT        *
FROM            (SELECT        ROW_NUMBER() OVER (partition BY tare_unit_no
                          ORDER BY tare_datetime DESC) AS NUMBER, [TARE_RAW_ID], [TARE_UNIT_NO], [TARE_DATETIME], [TARE_VALUE]
FROM            [DB_JT18].[dbo].[TBL_T_TARE_UNIT]) dt
WHERE        number = 1
) tr on un.UNIT_NO = tr.TARE_UNIT_NO
GO
/****** Object:  View [dbo].[VW_T_TARE_ACTIVE_TODAY]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VW_T_TARE_ACTIVE_TODAY]
AS
select TARE_RAW_ID, TARE_UNIT_NO, TARE_DATETIME, TARE_VALUE from (
SELECT ROW_NUMBER() OVER (partition BY tare_unit_no
            ORDER BY tare_datetime DESC) AS NUMBER,
			TARE_RAW_ID, TARE_UNIT_NO, TARE_DATETIME, TARE_VALUE
FROM   dbo.TBL_T_TARE_UNIT
WHERE (TARE_DATETIME BETWEEN CASE WHEN datepart(hour, getdate()) > 6 THEN CAST(CONVERT(varchar, getdate(), 112) + ' 06:00' AS datetime) ELSE CAST(CONVERT(varchar, dateadd(day, - 1, getdate()), 112) + ' 06:00' AS datetime) END AND CASE WHEN datepart(hour, getdate()) < 6 THEN CAST(CONVERT(varchar, getdate(), 112) 
           + ' 06:00' AS datetime) ELSE CAST(CONVERT(varchar, dateadd(day, 1, getdate()), 112) + ' 06:00' AS datetime) END)
		   ) dt
		   where number = 1
GO
/****** Object:  View [dbo].[VW_T_REVIEW_TARE]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_T_REVIEW_TARE]
AS
SELECT unit.UNIT_NO, unit.UNIT_ENTITY,  mx.TARE_VALUE AS TARE, ISNULL(tdy.TARE_DATETIME, mx.TARE_DATETIME) AS [LAST TARE]
FROM   dbo.TBL_R_UNIT AS unit LEFT OUTER JOIN
           dbo.VW_T_TARE_ACTIVE_TODAY AS tdy ON unit.UNIT_NO = tdy.TARE_UNIT_NO LEFT OUTER JOIN
           dbo.VW_T_MAX_TARE AS mx ON mx.TARE_UNIT_NO = unit.UNIT_NO
WHERE (unit.UNIT_AKTIF = 1)
GO
/****** Object:  Table [dbo].[TBL_R_CPP]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_R_CPP](
	[CPP_CODE] [varchar](10) NOT NULL,
	[CPP_ENTITY] [varchar](5) NOT NULL,
	[CPP_LOKASI] [varchar](100) NOT NULL,
	[CPP_DESC] [varchar](200) NULL,
	[CPP_AKTIF] [varchar](1) NOT NULL,
 CONSTRAINT [PK_TBL_R_CPP] PRIMARY KEY CLUSTERED 
(
	[CPP_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_R_ENTITY]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_R_ENTITY](
	[ENTITY_CODE] [varchar](5) NOT NULL,
	[ENTITY_NAME] [varchar](200) NOT NULL,
	[ENTITY_AKTIF] [varchar](1) NOT NULL,
 CONSTRAINT [PK_TBL_R_ENTITY] PRIMARY KEY CLUSTERED 
(
	[ENTITY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_R_PRODUCT]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_R_PRODUCT](
	[PRODUCT_CODE] [varchar](20) NOT NULL,
	[PRODUCT_ENTITY] [varchar](5) NOT NULL,
	[PRODUCT_NAME] [varchar](200) NOT NULL,
	[PRODUCT_DESC] [varchar](200) NULL,
	[PRODUCT_ACTIVE] [varchar](1) NOT NULL,
 CONSTRAINT [PK_TBL_R_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[PRODUCT_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_R_STOCKPILE]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_R_STOCKPILE](
	[STOCKPILE_CODE] [varchar](20) NOT NULL,
	[STOCKPILE_NAME] [varchar](30) NOT NULL,
	[STOCKPILE_LOKASI] [varchar](100) NULL,
	[STOCKPILE_DESC] [varchar](200) NULL,
	[STOCKPILE_AKTIF] [nchar](10) NOT NULL,
 CONSTRAINT [PK_TBL_R_STOCKPILE] PRIMARY KEY CLUSTERED 
(
	[STOCKPILE_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_T_TRANSAKSI_18]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_T_TRANSAKSI_18](
	[TRANS_RAW_ID] [varchar](200) NOT NULL,
	[TRANS_UNIT] [varchar](10) NOT NULL,
	[TRANS_ENTITY] [varchar](5) NOT NULL,
	[TRANS_CPP] [varchar](10) NOT NULL,
	[TRANS_PRODUCT] [varchar](10) NOT NULL,
	[TRANS_STOCKPILE] [varchar](10) NOT NULL,
	[TRANS_LOADER] [varchar](10) NULL,
	[TRANS_GROSS] [int] NOT NULL,
	[TRANS_TARE] [int] NOT NULL,
	[TRANS_START_TIMBANG] [datetime] NOT NULL,
	[TRANS_DATETIME] [datetime] NOT NULL,
	[TRANS_UPDATE_AT] [datetime] NOT NULL,
	[TRANS_OPERATOR] [varchar](20) NOT NULL,
	[TRANS_DOCKET_ID] [varchar](200) NULL,
 CONSTRAINT [PK_TBL_T_TRANSAKSI_18] PRIMARY KEY CLUSTERED 
(
	[TRANS_RAW_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_T_TRANSAKSI]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_T_TRANSAKSI]
AS
SELECT        TOP (100) PERCENT trans.TRANS_RAW_ID, CASE WHEN CAST([TRANS_DATETIME] AS time) > '05:30' THEN CONVERT(varchar, [TRANS_DATETIME], 112) ELSE CONVERT(varchar, dateadd(day, - 1, [TRANS_DATETIME]), 112) 
                         END AS TRANS_TGL_PRODUKSI, CASE WHEN CAST([TRANS_DATETIME] AS time) BETWEEN '05:30' AND '17:30' THEN 'S1' ELSE 'S2' END AS TRANS_SHIFT, trans.TRANS_UNIT, unit.UNIT_ENTITY, entity.ENTITY_NAME, 
                         trans.TRANS_ENTITY, trans.TRANS_CPP, cpp.CPP_ENTITY, trans.TRANS_PRODUCT, pro.PRODUCT_NAME, trans.TRANS_LOADER, trans.TRANS_GROSS, trans.TRANS_TARE, 
                         trans.TRANS_GROSS - trans.TRANS_TARE AS TRANS_NETTO, trans.TRANS_STOCKPILE, sto.STOCKPILE_NAME, trans.TRANS_START_TIMBANG, trans.TRANS_DATETIME, trans.TRANS_UPDATE_AT, trans.TRANS_OPERATOR, 
                         trans.TRANS_DOCKET_ID
FROM            dbo.TBL_T_TRANSAKSI_18 AS trans LEFT OUTER JOIN
                         dbo.TBL_R_UNIT AS unit ON trans.TRANS_UNIT = unit.UNIT_NO LEFT OUTER JOIN
                         dbo.TBL_R_ENTITY AS entity ON trans.TRANS_ENTITY = entity.ENTITY_CODE LEFT OUTER JOIN
                         dbo.TBL_R_CPP AS cpp ON trans.TRANS_CPP = cpp.CPP_CODE LEFT OUTER JOIN
                         dbo.TBL_R_PRODUCT AS pro ON trans.TRANS_PRODUCT = pro.PRODUCT_CODE LEFT OUTER JOIN
                         dbo.TBL_R_STOCKPILE AS sto ON trans.TRANS_STOCKPILE = sto.STOCKPILE_CODE
ORDER BY trans.TRANS_DATETIME
GO
/****** Object:  View [dbo].[VW_T_TRANSAKSI_SLIP]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_T_TRANSAKSI_SLIP]
AS
SELECT        trans.TRANS_RAW_ID, CASE WHEN CAST([TRANS_DATETIME] AS time) > '05:30' THEN CONVERT(varchar, [TRANS_DATETIME], 112) ELSE CONVERT(varchar, dateadd(day, - 1, [TRANS_DATETIME]), 112) 
                         END AS TRANS_TGL_PRODUKSI, trans.TRANS_UNIT, unit.UNIT_ENTITY, unit.UNIT_KONTRAKTOR, trans.TRANS_ENTITY, entity.ENTITY_NAME, trans.TRANS_CPP, cpp.CPP_LOKASI, trans.TRANS_PRODUCT, 
                         pro.PRODUCT_NAME, trans.TRANS_LOADER, trans.TRANS_GROSS, trans.TRANS_TARE, trans.TRANS_GROSS - trans.TRANS_TARE AS TRANS_NETTO, trans.TRANS_STOCKPILE, sto.STOCKPILE_NAME, sto.STOCKPILE_LOKASI, 
                         trans.TRANS_START_TIMBANG, trans.TRANS_DATETIME, trans.TRANS_UPDATE_AT, trans.TRANS_OPERATOR, trans.TRANS_DOCKET_ID
FROM            dbo.TBL_T_TRANSAKSI_18 AS trans LEFT OUTER JOIN
                         dbo.TBL_R_UNIT AS unit ON trans.TRANS_UNIT = unit.UNIT_NO LEFT OUTER JOIN
                         dbo.TBL_R_ENTITY AS entity ON trans.TRANS_ENTITY = entity.ENTITY_CODE LEFT OUTER JOIN
                         dbo.TBL_R_CPP AS cpp ON trans.TRANS_CPP = cpp.CPP_CODE LEFT OUTER JOIN
                         dbo.TBL_R_PRODUCT AS pro ON trans.TRANS_PRODUCT = pro.PRODUCT_CODE LEFT OUTER JOIN
                         dbo.TBL_R_STOCKPILE AS sto ON trans.TRANS_STOCKPILE = sto.STOCKPILE_CODE
GO
/****** Object:  Table [dbo].[TBL_R_CONTRACTOR]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_R_CONTRACTOR](
	[CONTRACTOR_CODE] [varchar](5) NOT NULL,
	[CONTRACTOR_NAME] [varchar](200) NOT NULL,
	[CONTRACTOR_AKTIF] [varchar](1) NOT NULL,
 CONSTRAINT [PK_TBL_R_CONTRACTOR] PRIMARY KEY CLUSTERED 
(
	[CONTRACTOR_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TBL_M_AKSES] ([AKSES_RAW_ID], [AKSES_NAME]) VALUES (N'0B2DCFD8-D828-4E72-A5BB-DB46F9ECF252', N'ADMINISTRATOR')
INSERT [dbo].[TBL_M_AKSES] ([AKSES_RAW_ID], [AKSES_NAME]) VALUES (N'B1CFCEAA-0214-4436-8BAE-45E69F086B03', N'OPERATOR')
GO
INSERT [dbo].[TBL_R_CONTRACTOR] ([CONTRACTOR_CODE], [CONTRACTOR_NAME], [CONTRACTOR_AKTIF]) VALUES (N'KPP', N'KPO', N'1')
INSERT [dbo].[TBL_R_CONTRACTOR] ([CONTRACTOR_CODE], [CONTRACTOR_NAME], [CONTRACTOR_AKTIF]) VALUES (N'PM', N'PAMA', N'1')
GO
INSERT [dbo].[TBL_R_CPP] ([CPP_CODE], [CPP_ENTITY], [CPP_LOKASI], [CPP_DESC], [CPP_AKTIF]) VALUES (N'BHT', N'TOP', N'BUHUT', N'-', N'1')
INSERT [dbo].[TBL_R_CPP] ([CPP_CODE], [CPP_ENTITY], [CPP_LOKASI], [CPP_DESC], [CPP_AKTIF]) VALUES (N'SKK', N'SMM', N'SEKAKO', N'-', N'1')
INSERT [dbo].[TBL_R_CPP] ([CPP_CODE], [CPP_ENTITY], [CPP_LOKASI], [CPP_DESC], [CPP_AKTIF]) VALUES (N'SPN', N'ABB', N'SPANURING', N'-', N'1')
GO
INSERT [dbo].[TBL_R_ENTITY] ([ENTITY_CODE], [ENTITY_NAME], [ENTITY_AKTIF]) VALUES (N'ABB', N'ASMIN BARA BARONANG', N'1')
INSERT [dbo].[TBL_R_ENTITY] ([ENTITY_CODE], [ENTITY_NAME], [ENTITY_AKTIF]) VALUES (N'SMM', N'SUPRABARI MAPANINDO', N'1')
INSERT [dbo].[TBL_R_ENTITY] ([ENTITY_CODE], [ENTITY_NAME], [ENTITY_AKTIF]) VALUES (N'TOP', N'TELEN ORBIT PRIMA', N'1')
GO
INSERT [dbo].[TBL_R_MENU] ([Primer], [Id], [Menu], [Menu_link], [Link], [Urutan], [Deskripsi], [style_class]) VALUES (1, 0, N'JT SMM', 1, N'#', 1, NULL, NULL)
INSERT [dbo].[TBL_R_MENU] ([Primer], [Id], [Menu], [Menu_link], [Link], [Urutan], [Deskripsi], [style_class]) VALUES (5, 0, N'Report', 5, N'#', 5, NULL, NULL)
INSERT [dbo].[TBL_R_MENU] ([Primer], [Id], [Menu], [Menu_link], [Link], [Urutan], [Deskripsi], [style_class]) VALUES (101, 1, N'Manage Data', 0, N'TransaksiJTSMM/index', 1, NULL, NULL)
INSERT [dbo].[TBL_R_MENU] ([Primer], [Id], [Menu], [Menu_link], [Link], [Urutan], [Deskripsi], [style_class]) VALUES (500, 5, N'Report JT SMM', 500, N'#', 5, NULL, NULL)
INSERT [dbo].[TBL_R_MENU] ([Primer], [Id], [Menu], [Menu_link], [Link], [Urutan], [Deskripsi], [style_class]) VALUES (501, 500, N'Report Resume', 0, N'/Report/Index?rptid=1', 1, NULL, NULL)
INSERT [dbo].[TBL_R_MENU] ([Primer], [Id], [Menu], [Menu_link], [Link], [Urutan], [Deskripsi], [style_class]) VALUES (502, 500, N'Report Shiftly', 0, N'/Report/Index?rptid=2', 2, NULL, NULL)
GO
INSERT [dbo].[TBL_R_MENU_LOGIN] ([Menu_primer], [User_level]) VALUES (N'1', N'0')
INSERT [dbo].[TBL_R_MENU_LOGIN] ([Menu_primer], [User_level]) VALUES (N'101', N'0')
INSERT [dbo].[TBL_R_MENU_LOGIN] ([Menu_primer], [User_level]) VALUES (N'5', N'0')
INSERT [dbo].[TBL_R_MENU_LOGIN] ([Menu_primer], [User_level]) VALUES (N'500', N'0')
INSERT [dbo].[TBL_R_MENU_LOGIN] ([Menu_primer], [User_level]) VALUES (N'501', N'0')
INSERT [dbo].[TBL_R_MENU_LOGIN] ([Menu_primer], [User_level]) VALUES (N'502', N'0')
GO
INSERT [dbo].[TBL_R_PRODUCT] ([PRODUCT_CODE], [PRODUCT_ENTITY], [PRODUCT_NAME], [PRODUCT_DESC], [PRODUCT_ACTIVE]) VALUES (N'ABX', N'ABB', N'ABX', N'X+', N'1')
INSERT [dbo].[TBL_R_PRODUCT] ([PRODUCT_CODE], [PRODUCT_ENTITY], [PRODUCT_NAME], [PRODUCT_DESC], [PRODUCT_ACTIVE]) VALUES (N'AWRL', N'TOP', N'AWRL', N'RL', N'1')
INSERT [dbo].[TBL_R_PRODUCT] ([PRODUCT_CODE], [PRODUCT_ENTITY], [PRODUCT_NAME], [PRODUCT_DESC], [PRODUCT_ACTIVE]) VALUES (N'SM1', N'SMM', N'SM1', N'1', N'1')
GO
INSERT [dbo].[TBL_R_STOCKPILE] ([STOCKPILE_CODE], [STOCKPILE_NAME], [STOCKPILE_LOKASI], [STOCKPILE_DESC], [STOCKPILE_AKTIF]) VALUES (N'SP1', N'PARING LAHUNG', N'STOCKPILE 1', N'-', N'1         ')
INSERT [dbo].[TBL_R_STOCKPILE] ([STOCKPILE_CODE], [STOCKPILE_NAME], [STOCKPILE_LOKASI], [STOCKPILE_DESC], [STOCKPILE_AKTIF]) VALUES (N'SP2', N'PARING LAHUNG', N'STOCKPILE 2', N'-', N'1         ')
INSERT [dbo].[TBL_R_STOCKPILE] ([STOCKPILE_CODE], [STOCKPILE_NAME], [STOCKPILE_LOKASI], [STOCKPILE_DESC], [STOCKPILE_AKTIF]) VALUES (N'SP3', N'PARING LAHUNG', N'STOCKPILE 3', N'-', N'1         ')
GO
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT123', N'SMM', N'P410', N'PAMA', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT124', N'TOP', N'P410', N'SAMS', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT125', N'SMM', N'P410', N'PAMA', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT126', N'ABB', N'P410', N'KPP', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT127', N'ABB', N'P410', N'KPP', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT128', N'ABB', N'P410', N'KPP', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT129', N'SMM', N'P410', N'PAMA', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT130', N'ABB', N'P410', N'KPP', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT131', N'ABB', N'P410', N'KPP', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT132', N'TOP', N'P410', N'SAMS', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT133', N'SMM', N'P410', N'PAMA', 15000, N'1')
INSERT [dbo].[TBL_R_UNIT] ([UNIT_NO], [UNIT_ENTITY], [UNIT_EGI], [UNIT_KONTRAKTOR], [UNIT_DEFAULT_TARE], [UNIT_AKTIF]) VALUES (N'DT135', N'TOP', N'P410', N'SAMS', 15000, N'1')
GO
INSERT [dbo].[TBL_R_USER] ([USER_RAW_ID], [USER_NAME], [USER_COMPANY], [USER_AKSES], [USER_USERNAME], [USER_PASSWORD]) VALUES (N'1AAD65C3-C71C-41D5-AC2B-AE388323FC87', N'Bayu', N'SMM', N'0B2DCFD8-D828-4E72-A5BB-DB46F9ECF252', N'6112508', N'7BBF9DE5CF722F9F8F4BB8C49B6770A7')
INSERT [dbo].[TBL_R_USER] ([USER_RAW_ID], [USER_NAME], [USER_COMPANY], [USER_AKSES], [USER_USERNAME], [USER_PASSWORD]) VALUES (N'4BA52549-B59B-4847-92AF-E1888FC34333', N'Operator', N'PT. SMM', N'B1CFCEAA-0214-4436-8BAE-45E69F086B03', N'OPR1', N'4B583376B2767B923C3E1DA60D10DE59')
INSERT [dbo].[TBL_R_USER] ([USER_RAW_ID], [USER_NAME], [USER_COMPANY], [USER_AKSES], [USER_USERNAME], [USER_PASSWORD]) VALUES (N'5EC8E838-7119-48A1-BF90-C54A2C0FD29F', N'Fauzan', N'SMM', N'B1CFCEAA-0214-4436-8BAE-45E69F086B03', N'opr2', N'4B583376B2767B923C3E1DA60D10DE59')
INSERT [dbo].[TBL_R_USER] ([USER_RAW_ID], [USER_NAME], [USER_COMPANY], [USER_AKSES], [USER_USERNAME], [USER_PASSWORD]) VALUES (N'F5230779-03C2-4204-853E-7855C9B49706', N'Administrator', N'PT. SMM', N'0B2DCFD8-D828-4E72-A5BB-DB46F9ECF252', N'Admin', N'21232F297A57A5A743894A0E4A801FC3')
GO
INSERT [dbo].[TBL_T_TARE_UNIT] ([TARE_RAW_ID], [TARE_UNIT_NO], [TARE_VALUE], [TARE_DATETIME]) VALUES (N'4EC60246-760E-4BD2-AA1B-586B3D9230C3', N'DT123', 47500, CAST(N'2022-04-12T11:33:24.857' AS DateTime))
INSERT [dbo].[TBL_T_TARE_UNIT] ([TARE_RAW_ID], [TARE_UNIT_NO], [TARE_VALUE], [TARE_DATETIME]) VALUES (N'A1CDB24E-30F9-44AF-95A1-B0C1382CE08E', N'DT111', 50000, CAST(N'2022-04-12T11:31:46.467' AS DateTime))
INSERT [dbo].[TBL_T_TARE_UNIT] ([TARE_RAW_ID], [TARE_UNIT_NO], [TARE_VALUE], [TARE_DATETIME]) VALUES (N'NEWID()', N'DT123', 1500000, CAST(N'2022-04-12T11:30:18.863' AS DateTime))
GO
INSERT [dbo].[TBL_T_TRANSAKSI_18] ([TRANS_RAW_ID], [TRANS_UNIT], [TRANS_ENTITY], [TRANS_CPP], [TRANS_PRODUCT], [TRANS_STOCKPILE], [TRANS_LOADER], [TRANS_GROSS], [TRANS_TARE], [TRANS_START_TIMBANG], [TRANS_DATETIME], [TRANS_UPDATE_AT], [TRANS_OPERATOR], [TRANS_DOCKET_ID]) VALUES (N'34332730-3b89-4695-9236-53398b083836', N'DT123', N'ABB', N'SPN', N'ABX', N'SP1', N'EX', 47500, 15000, CAST(N'2022-04-12T08:59:49.000' AS DateTime), CAST(N'2022-04-12T08:59:49.000' AS DateTime), CAST(N'2022-04-14T11:16:14.710' AS DateTime), N'TR', NULL)
INSERT [dbo].[TBL_T_TRANSAKSI_18] ([TRANS_RAW_ID], [TRANS_UNIT], [TRANS_ENTITY], [TRANS_CPP], [TRANS_PRODUCT], [TRANS_STOCKPILE], [TRANS_LOADER], [TRANS_GROSS], [TRANS_TARE], [TRANS_START_TIMBANG], [TRANS_DATETIME], [TRANS_UPDATE_AT], [TRANS_OPERATOR], [TRANS_DOCKET_ID]) VALUES (N'8b327370-b292-4f3e-bb57-6a00afb43d30', N'DT123', N'ABB', N'SPN', N'ABX', N'SP1', N'10', 7500000, 47500, CAST(N'2022-04-12T10:56:50.000' AS DateTime), CAST(N'2022-04-12T10:56:58.000' AS DateTime), CAST(N'2022-04-12T10:57:03.690' AS DateTime), N'TR', NULL)
INSERT [dbo].[TBL_T_TRANSAKSI_18] ([TRANS_RAW_ID], [TRANS_UNIT], [TRANS_ENTITY], [TRANS_CPP], [TRANS_PRODUCT], [TRANS_STOCKPILE], [TRANS_LOADER], [TRANS_GROSS], [TRANS_TARE], [TRANS_START_TIMBANG], [TRANS_DATETIME], [TRANS_UPDATE_AT], [TRANS_OPERATOR], [TRANS_DOCKET_ID]) VALUES (N'c48f1442-9332-4934-ada6-291d95a4de45', N'DT123', N'ABB', N'SPN', N'ABX', N'SP1', N'15', 1500000, 47500, CAST(N'2022-04-12T17:21:17.000' AS DateTime), CAST(N'2022-04-12T17:21:22.000' AS DateTime), CAST(N'2022-04-12T11:21:25.023' AS DateTime), N'TR', NULL)
GO
ALTER TABLE [dbo].[TBL_M_AKSES] ADD  CONSTRAINT [DF_TBL_M_AKSES_AKSES_RAW_ID]  DEFAULT (newid()) FOR [AKSES_RAW_ID]
GO
ALTER TABLE [dbo].[TBL_R_CONTRACTOR] ADD  CONSTRAINT [DF_TBL_R_CONTRACTOR_CONTRACTOR_AKTIF]  DEFAULT ((1)) FOR [CONTRACTOR_AKTIF]
GO
ALTER TABLE [dbo].[TBL_R_CPP] ADD  CONSTRAINT [DF_TBL_R_CPP_CPP_AKTIF]  DEFAULT ((1)) FOR [CPP_AKTIF]
GO
ALTER TABLE [dbo].[TBL_R_ENTITY] ADD  CONSTRAINT [DF_TBL_R_ENTITY_ENTITY_AKTIF]  DEFAULT ((1)) FOR [ENTITY_AKTIF]
GO
ALTER TABLE [dbo].[TBL_R_PRODUCT] ADD  CONSTRAINT [DF_TBL_R_PRODUCT_PRODUCT_ACTIVE]  DEFAULT ((1)) FOR [PRODUCT_ACTIVE]
GO
ALTER TABLE [dbo].[TBL_R_STOCKPILE] ADD  CONSTRAINT [DF_TBL_R_STOCKPILE_STOCKPILE_AKTIF]  DEFAULT ((1)) FOR [STOCKPILE_AKTIF]
GO
ALTER TABLE [dbo].[TBL_R_UNIT] ADD  CONSTRAINT [DF_TBL_R_UNIT_UNIT_AKTIF]  DEFAULT ((1)) FOR [UNIT_AKTIF]
GO
ALTER TABLE [dbo].[TBL_R_USER] ADD  CONSTRAINT [DF_TBL_R_USER_USER_RAW_ID]  DEFAULT (newid()) FOR [USER_RAW_ID]
GO
ALTER TABLE [dbo].[TBL_T_TARE_UNIT] ADD  CONSTRAINT [DF_TBL_T_TARE_UNIT_TARE_RAW_ID]  DEFAULT (newid()) FOR [TARE_RAW_ID]
GO
ALTER TABLE [dbo].[TBL_T_TARE_UNIT] ADD  CONSTRAINT [DF_TBL_T_TARE_UNIT_TARE_DATETIME]  DEFAULT (getdate()) FOR [TARE_DATETIME]
GO
ALTER TABLE [dbo].[TBL_T_TRANSAKSI_18] ADD  CONSTRAINT [DF_TBL_T_TRANSAKSI_18_TRANS_RAW_ID]  DEFAULT (newid()) FOR [TRANS_RAW_ID]
GO
ALTER TABLE [dbo].[TBL_T_TRANSAKSI_18] ADD  CONSTRAINT [DF_TBL_T_TRANSAKSI_18_TRANS_DATETIME]  DEFAULT (getdate()) FOR [TRANS_DATETIME]
GO
ALTER TABLE [dbo].[TBL_T_TRANSAKSI_18] ADD  CONSTRAINT [DF_TBL_T_TRANSAKSI_18_TRANS_UPDATE_AT]  DEFAULT (getdate()) FOR [TRANS_UPDATE_AT]
GO
/****** Object:  StoredProcedure [dbo].[cekUser]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cekUser]
(
	@USER_USERNAME varchar(10),
	@USER_PASSWORD varchar(200)
)
AS
	SET NOCOUNT ON;
SELECT        COUNT(*) AS JML
FROM            TBL_R_USER
WHERE        (USER_USERNAME = @USER_USERNAME) AND (USER_PASSWORD = CONVERT(VARCHAR(32), HashBytes('MD5', '' + @USER_PASSWORD), 2))
GO
/****** Object:  StoredProcedure [dbo].[cusp_pagingtable]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[cusp_pagingtable](
@tablename varchar(100),	
@filter varchar(MAX),
@sort varchar(MAX),
@page_size int,
@page_index int)
AS
BEGIN
	DECLARE @query_string varchar(MAX)
DECLARE @number_row varchar(20)

SET @number_row = CONVERT(varchar,@page_size)

IF @filter = '' SET @filter = '1=1'
IF @page_size = 0 SET @number_row = '(100) PERCENT'

SET @query_string = '
SELECT TOP ' + @number_row + ' * 
FROM (SELECT ROW_NUMBER() OVER(ORDER BY ' + @sort + ') AS ROW_NUMBER, * 
	  FROM (SELECT ' + @tablename + '.* FROM ' + @tablename + '
	  WHERE ' + @filter + ') as drv) AS drv_temp 
WHERE ROW_NUMBER > (' + CONVERT(varchar,((@page_index - 1) * @page_size)) + ') ORDER BY ROW_NUMBER'

print @query_string

BEGIN TRY
    EXEC(@query_string)
END TRY
BEGIN CATCH
	--SELECT ERROR_MESSAGE() AS ROW_NUMBER
	--SELECT @query_string AS ROW_NUMBER
END CATCH;
END
GO
/****** Object:  StoredProcedure [dbo].[CUSP_UPDATE_TRANSAKSI]    Script Date: 27/04/2022 14:07:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CUSP_UPDATE_TRANSAKSI] 
	@TRANS_RAW_ID  varchar(200), @TRANS_UNIT  varchar(10), @TRANS_ENTITY  varchar(5),
	@TRANS_CPP  varchar(10), @TRANS_PRODUCT  varchar(10), @TRANS_STOCKPILE  varchar(10),
	@TRANS_LOADER  varchar(10), @TRANS_GROSS  int, @TRANS_UPDATE_AT datetime,
	@TRANS_START_TIMBANG  datetime,@TRANS_DATETIME  datetime, @TRANS_OPERATOR  varchar(20)
AS
BEGIN

DECLARE @TRANS_TARE  int = null
DECLARE @default_TARE  int = null

set @default_TARE = (select [UNIT_DEFAULT_TARE] from [dbo].[TBL_R_UNIT] where [UNIT_NO] = @TRANS_UNIT  )
set @TRANS_TARE  = (SELECT TOP 1 [TARE_VALUE] FROM [dbo].[TBL_T_TARE_UNIT] WHERE [TARE_DATETIME] <= @TRANS_DATETIME AND [TARE_UNIT_NO] = @TRANS_UNIT ORDER BY [TARE_DATETIME] DESC)

set @TRANS_TARE = isnull(@TRANS_TARE,@default_TARE)

UPDATE [DB_JT18].[dbo].[TBL_T_TRANSAKSI_18]
SET   [TRANS_UNIT] = @TRANS_UNIT
      ,[TRANS_ENTITY] = @TRANS_ENTITY
      ,[TRANS_CPP] = @TRANS_CPP
      ,[TRANS_PRODUCT] = @TRANS_PRODUCT
      ,[TRANS_STOCKPILE] = @TRANS_STOCKPILE
      ,[TRANS_LOADER] = @TRANS_LOADER
      ,[TRANS_GROSS] = @TRANS_GROSS
	  ,[TRANS_TARE] = @TRANS_TARE
      ,[TRANS_UPDATE_AT] = GETDATE()
      ,[TRANS_START_TIMBANG] = @TRANS_START_TIMBANG
      ,[TRANS_DATETIME] = @TRANS_DATETIME
      ,[TRANS_OPERATOR] = @TRANS_OPERATOR
  WHERE [TRANS_RAW_ID] = @TRANS_RAW_ID
    
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "usr"
            Begin Extent = 
               Top = 10
               Left = 67
               Bottom = 240
               Right = 347
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "aks"
            Begin Extent = 
               Top = 10
               Left = 414
               Bottom = 176
               Right = 669
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_R_USER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_R_USER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_MAX_TARE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_MAX_TARE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "unit"
            Begin Extent = 
               Top = 10
               Left = 67
               Bottom = 240
               Right = 367
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tdy"
            Begin Extent = 
               Top = 10
               Left = 434
               Bottom = 240
               Right = 700
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "mx"
            Begin Extent = 
               Top = 10
               Left = 767
               Bottom = 240
               Right = 1033
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 857
         Width = 857
         Width = 857
         Width = 857
         Width = 857
         Width = 857
         Width = 857
         Width = 857
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_REVIEW_TARE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_REVIEW_TARE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_T_TARE"
            Begin Extent = 
               Top = 10
               Left = 67
               Bottom = 240
               Right = 333
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 857
         Width = 857
         Width = 857
         Width = 857
         Width = 857
         Width = 857
         Width = 857
         Width = 857
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1174
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1354
         SortOrder = 1414
         GroupBy = 1350
         Filter = 1354
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_TARE_ACTIVE_TODAY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_TARE_ACTIVE_TODAY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "trans"
            Begin Extent = 
               Top = 10
               Left = 67
               Bottom = 502
               Right = 398
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "unit"
            Begin Extent = 
               Top = 112
               Left = 681
               Bottom = 242
               Right = 881
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "entity"
            Begin Extent = 
               Top = 109
               Left = 494
               Bottom = 222
               Right = 664
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cpp"
            Begin Extent = 
               Top = 286
               Left = 717
               Bottom = 416
               Right = 887
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "pro"
            Begin Extent = 
               Top = 214
               Left = 942
               Bottom = 344
               Right = 1127
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sto"
            Begin Extent = 
               Top = 264
               Left = 453
               Bottom = 394
               Right = 656
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 26
         Width = 284
         Width = 855
         Width = 855
         Width = ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_TRANSAKSI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2745
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_TRANSAKSI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_TRANSAKSI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -384
         Left = 0
      End
      Begin Tables = 
         Begin Table = "trans"
            Begin Extent = 
               Top = 4
               Left = 30
               Bottom = 409
               Right = 361
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "unit"
            Begin Extent = 
               Top = 420
               Left = 38
               Bottom = 550
               Right = 238
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "entity"
            Begin Extent = 
               Top = 337
               Left = 466
               Bottom = 450
               Right = 636
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cpp"
            Begin Extent = 
               Top = 534
               Left = 276
               Bottom = 664
               Right = 446
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "pro"
            Begin Extent = 
               Top = 552
               Left = 38
               Bottom = 682
               Right = 223
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sto"
            Begin Extent = 
               Top = 666
               Left = 261
               Bottom = 796
               Right = 452
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 22
         Width = 284
         Width = 855
         Width = 855
         Width = 85' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_TRANSAKSI_SLIP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'5
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 855
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_TRANSAKSI_SLIP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_T_TRANSAKSI_SLIP'
GO
