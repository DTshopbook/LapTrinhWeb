CREATE TABLE dbo.Orders
(
	OrderID INT IDENTITY(1,1) PRIMARY KEY,
	CreateDate DATETIME,
	UserRealName NVARCHAR(50),
	UserAddress NVARCHAR(200),
	UserPhone NVARCHAR(10),
	UserEmail NVARCHAR(100),
	Status bit
)



CREATE TABLE dbo.InfoWebsite
(
	Webname NVARCHAR(50) PRIMARY KEY,
	WebPhone NVARCHAR(10),
	WebAddress NVARCHAR(1000),
	WebEmail NVARCHAR(250)
)

ALTER TABLE dbo.Orders ADD UserMail NVARCHAR(100)
DROP TABLE dbo.Orders
ALTER TABLE dbo.OrdersDetail ADD FOREIGN KEY (OrderID) REFERENCES dbo.Orders(OrderID)
ALTER TABLE dbo.Users DROP COLUMN CartID 
