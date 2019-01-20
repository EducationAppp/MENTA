use Education

--従業員テーブル
CREATE TABLE [dbo].[Employee](
	[EmployeeCode] [int] NOT NULL primary key,
	[Name] [nvarchar](50) NULL,
	[NameKana] [nvarchar](50) NULL,
	[Adress] [nvarchar](50) NOT NULL,
	[Sex]  [int]  NULL,
	[Age] [int] NOT NULL,
	[BirthDay] [date] NOT NULL,
	[Engagement]  [int]  NULL,
	[Blood] [nchar](10)  NULL,
	[Prefectures] [nchar](10)  NULL,
	[PrefecturesCode] [int]  NULL,
	[CellPhone] [nvarchar](50) NULL)

--商品マスタテーブル
CREATE TABLE ItemMaster(
	[ItemCode] [int] NOT NULL primary key,
	[ItemName] [nvarchar](40) NOT NULL ,
	[ItemNameKana] [nvarchar](80) NULL,
	[SupplyCompanyCode] [int] NULL,
	[ItemAreaCode] [int] NULL,
	[Price] [money] NULL,
	[Stock] [smallint] NULL,
	[StopFlag] [bit] NOT NULL)

--商品区分テーブル
CREATE TABLE ItemAreaMaster(
	[ItemAreaCode] [int] NOT NULL,
	[ItemAreaName] [nvarchar](30) NOT NULL,
	[Description] [nvarchar](max) NULL)

--仕入れ先
CREATE TABLE [dbo].[SupplyCompany](
	[SupplyCompanyCode] [int] NOT NULL,
	[SupplyCompanyName] [nvarchar](40) NOT NULL,
	[SupplyCompanyNameKana] [nvarchar](80) NULL,
	[SupervisorName] [nvarchar](30) NULL,
	[Department] [nvarchar](30) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[PrefecturesCode] [nvarchar](15) NULL,
	[Adress1] [nvarchar](60) NULL,
	[Adress2] [nvarchar](60) NULL)

