Create Database BankDb
Go
Use BankDb
Go
Create Table Users(
	UserId Int Identity Primary Key,
	Username Varchar(50) Not Null,
	Password Varchar(50) Not Null,
	IsActive Bit Default 1
)
Go
Create Table Customers
(
	[CustomerID] int Primary Key Identity,
	[ContactName] [nvarchar](30) NULL,
	[ContactTitle] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
	[Fax] [nvarchar](24) NULL,
)
