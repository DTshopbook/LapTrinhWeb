USE ShopBook
GO

CREATE TABLE dbo.Users
(
	Username nvarchar(50) PRIMARY KEY NOT NULL,
	Pasword nvarchar(50),
	Rank int,
	Statuss int,
	CartID nvarchar(10)
)
GO

ALTER TABLE dbo.Users ALTER COLUMN Statuss bit
GO
ALTER TABLE dbo.Users ADD CreateDate DATETIME
GO
ALTER TABLE dbo.Users ADD Email NVARCHAR(50)
GO

CREATE TABLE dbo.Product
(
	ProductID NVARCHAR(50) PRIMARY KEY NOT NULL,
	NameBook NVARCHAR(50),
	WriterID NVARCHAR(50),
	NxbID NVARCHAR(50),
	Price FLOAT,
	Amount INT, --So luong con lai
	Describe NVARCHAR(100),
	CatogoryID NVARCHAR(50),
	ImageID NVARCHAR(50)
)
GO
ALTER TABLE dbo.Product ADD CategoryID NVARCHAR(50)
GO 
CREATE TABLE dbo.Catogory
(
	CatogoryID NVARCHAR(50) PRIMARY KEY NOT NULL,
	CatogoryName NVARCHAR(50)
)
GO
ALTER TABLE dbo.Category ADD Statuss bit
Go


CREATE TABLE dbo.Nxb
(
	NxbID NVARCHAR(50) PRIMARY KEY NOT NULL,
	NxbName NVARCHAR(50),
	NxbAddress NVARCHAR(100)
)
GO

CREATE TABLE dbo.Writer
(
	WriterID NVARCHAR(50) PRIMARY KEY NOT NULL,
	WriterName NVARCHAR(50)
)
GO

CREATE TABLE dbo.Receipt
(
	ReceiptID NVARCHAR(50) PRIMARY KEY NOT NULL,
	DateCreate DATETIME,
	Username NVARCHAR(50),
	PriceTotal FLOAT,
	CartID NVARCHAR(50),
	ProductAmount INT
)
GO

CREATE TABLE dbo.UserDetail
(
	Username NVARCHAR(50),
	Realname NVARCHAR(50),
	UserAddress NVARCHAR(100),
	UserPhone NVARCHAR(10),
	UserEmail NVARCHAR(50)
)
GO

CREATE TABLE dbo.Cart
(
	CartID NVARCHAR(50) PRIMARY KEY NOT NULL,
	Usernamem NVARCHAR(50),
	ProductID NVARCHAR(50),
	ReceiptID NVARCHAR(50)
)
GO
 CREATE TABLE dbo.Menu
 (
	MenuID INT PRIMARY KEY NOT NULL,
	Content NVARCHAR(50),
	Link NVARCHAR(50),
	Targret NVARCHAR(50),
	Status BIT
 )
 GO
 ALTER TABLE dbo.Menu ADD TypeID INT
 GO

 CREATE TABLE dbo.Orders
 (
	OrderID NVARCHAR(50) PRIMARY KEY NOT NULL,
	CreateDate DATETIME,
	UserID NVARCHAR(50),
	UserRealName NVARCHAR(50),
	UserAddress NVARCHAR(MAX),
	UserPhone NVARCHAR(50),
	UserEmail NVARCHAR(200),
	Status bit	
 )
 GO

 CREATE TABLE dbo.OrderDetail
 (
	OrderID NVARCHAR(50) NOT NULL,
	ProductID NVARCHAR(50) NOT NULL,
	AmountPro INT NOT NULL,
	Total INT NOT NULL
 )
 GO
 ALTER TABLE dbo.OrderDetail ADD CONSTRAINT FK_orderID FOREIGN KEY (OrderID) REFERENCES dbo.Orders(OrderID)
 GO



