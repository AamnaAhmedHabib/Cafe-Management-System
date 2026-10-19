use [Vintage Cafe];

Create Table Users(
	UserID int Identity(1,1) constraint users_ID_pk Primary Key, --auto-incrementing ID
	FirstName Varchar(50),
	LastName Varchar(50),
	Email Nvarchar(50) constraint users_email_un Unique,
	Phone Nvarchar(20),
	Username Nvarchar(50) constraint users_username_un Unique,
	Password Nvarchar(50),
	Salary Decimal(8,2),
	Role Nvarchar(50),
	Status Nvarchar(50),
	ProfilePic Varbinary(MAX)
);

Create Table MenuItems(
	ItemID int Identity(1,1) constraint menuitems_ID_pk Primary Key, --auto-incrementing ID
	ItemName Varchar(50),
	Category Nvarchar(50),
	Price Decimal(8,2),
	ItemPic Varbinary(MAX)
);

Create Table Customers(
	CustomerID int Identity(1,1) constraint customers_ID_pk Primary Key, --auto-incrementing ID
	CreatedDate DateTime Default GetDate()
);

Create Table Orders(
	OrderID int Identity(1,1) constraint orders_ID_pk Primary Key, --auto-incrementing ID
	CustomerID int constraint orders_customerID_fk foreign key references Customers(CustomerID),
	ServerID int constraint orders_serverID_fk foreign key references Users(UserID),
	OrderDate DateTime Default Getdate(),
	Category Nvarchar(50),
	Payment Nvarchar(50),
	TotalItems int,
	TotalBill Decimal(8,2),
	DailySequence int
);

Create Table DailySummary(
	SummaryDate Date constraint DS_date_pk Primary Key,
	CustomerID int constraint DS_customerID_fk foreign key references Customers(CustomerID),
	UserID int constraint DS_serverID_fk foreign key references Users(UserID),
    TotalCustomers int Default 0,
    DailyRevenue Decimal(12,2) Default 0,
    LastUpdated DateTime Default Getdate()
);


Create Table CashierPerformance(
	PerformanceID int Identity(1,1) constraint performance_ID_pk Primary Key, --auto-incrementing ID
	UserID int constraint performance_userID_fk foreign key references Users(UserID),
	PerformanceDate Date,
    CustomersServed int Default 0,
    DailySales Decimal(12,2) Default 0
);

--To check if the stored procedure exists in the database
USE [Vintage Cafe]  
GO
SELECT * FROM INFORMATION_SCHEMA.ROUTINES 
WHERE ROUTINE_NAME = 'AddUsers';



