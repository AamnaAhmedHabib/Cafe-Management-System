Use [Vintage Cafe];

--Users Stored Procedure

---------Stored Procedure to Add New Users and Update Existing Users
--Adds new/updates users with all user detailst
Create Proc AddUsers 
    @UserID Int = NULL,
    @FirstName Varchar(50),
    @LastName Varchar(50),
    @Email Nvarchar(50),
    @Phone Nvarchar(50),
    @Username Nvarchar(50),
    @Password Nvarchar(50),
    @Salary Decimal(8,2),
    @Role Nvarchar(50),
    @Status Nvarchar(50),
    @ProfilePic Varbinary(MAX) = NULL 
As
Begin
    If @UserID Is Null --Null check on @UserID to tell if it's an insert or update
    Begin
        Insert Into Users (
            FirstName, LastName, Email, Phone, 
            Username, Password, Salary, Role, Status, ProfilePic
        )
        Values (
            @FirstName, @LastName, @Email, @Phone,
            @Username, @Password, @Salary, @Role, @Status, @ProfilePic
        )
    End
    Else -- Update user
    Begin
        Update Users Set
            FirstName = @FirstName,
            LastName = @LastName,
            Email = @Email,
            Phone = @Phone,
            Username = @Username,
            Password = @Password,
            Salary = @Salary,
            Role = @Role,
            Status = @Status,
            ProfilePic = Coalesce(@ProfilePic, ProfilePic) --If @ProfilePic parameter has a value (is NOT NULL), Coalesce uses that
        Where UserID = @UserID                             --If @ProfilePic is NULL, keep the existing ProfilePic value from the database
    End
End

-------------Stored Procedure to Retrieve Users Data from SQL to Winform (DGV)
Create proc GetUserData
As
Begin
Select [UserID],
      [FirstName],
      [LastName],
      [Email],
      [Phone],
      [Username],
      [Password],
      [Salary],
      [Role],
      [Status],
	  [ProfilePic]
  From [Vintage Cafe].[dbo].[Users]
 End


----------Stored Procedure to Delete Users
--Deletes a user by ID and resets identity counter if last user is deleted
--Currently causes foreign key violations with Orders table so the work around for that is the 'Inactive' label in the User Status(Trigger is there for this)
Create proc DeleteUser
    @UserID int
As
Begin
    Set Nocount on; --Doesnt show the messages
    
    --First delete the user
    Delete From Users Where UserID = @UserID;
    
    --Check if this was the last user
    If Not exists (Select 1 From Users)
    Begin
        --Reset the identity counter
        DBCC Checkident ('Users', Reseed, 0); --DBCC Checkident returns the current identity value
    End                                       --Reseed resets the next value, here it resets to zero when the last user is deleted
End


--This Stored Procedure is not to Update Users but to retrieve data for a specific user to populate the edit form for editing the Users
Create proc UpdateUser
	@UserID int
As
Begin 
Select [UserID],
      [FirstName],
      [LastName],
      [Email],
      [Phone],
      [Username],
      [Password],
      [Salary],
      [Role],
      [Status],
	  [ProfilePic]
  From [Vintage Cafe].[dbo].[Users]
  Where UserID = @UserID
 End

---------------------------------------------------------------------------

--MenuItems Stored Procedures

-------Stored Procedure to Add New Items and Update Existing Items
Create Proc AddItems
    @ItemID int = Null,
    @ItemName Nvarchar(100),
    @Price Decimal(8, 2),
    @Category Nvarchar(50),
    @ItemPic Varbinary(MAX) = Null
As
Begin
    If @ItemID Is Null Or Not Exists (Select 1 From MenuItems Where ItemID = @ItemID) --IsNull makes sure that no ItemID is already in use
    Begin                                                                             --Select 1 returns true if any row exists with that ID
        Insert Into MenuItems (ItemName, Price, Category, ItemPic)
        Values (@ItemName, @Price, @Category, @ItemPic);
    End
    Else --Item Update
    Begin
        Update MenuItems
        Set ItemName = @ItemName,
            Price = @Price,
            Category = @Category,
            ItemPic = @ItemPic
        Where ItemID = @ItemID;
    End
End

--This Stored Procedure is not to Update Items but to retrieve data for a specific Item to populate the edit form for editing the Item
Create proc UpdateItem
	@ItemID int
As
Begin 
Select [ItemID],
      [ItemName],
      [Category],
      [Price],
	  [ItemPic]
  From [Vintage Cafe].[dbo].[MenuItems]
  Where ItemID = @ItemID
 End

-----------------------------------------------------------------------------------------------------
--Customers Stored Procedures

-------Stored Procedure to add customers
--Adds a new customer and returns their ID and daily sequence number
Create or alter Proc AddCustomer
    @CustomerID int Output,
    @DailyCustomerNumber int Output
As
Begin
    Set Nocount On;
    
    Declare @Today Date = Cast(GetDate() As Date); --Casting it to 'Date' is making the code more efficient in a sense, since lesser lines of code 
    
    Insert Into Customers (CreatedDate) Values (GetDate());
    
    Set @CustomerID = Scope_Identity(); --Scope_Identity returns the last identity value that was inserted into identity column within the same scope
    
    -- Get today's customer count
    Select @DailyCustomerNumber = Count(*) 
    From  [Vintage Cafe].[dbo].[Customers]
    Where Cast(CreatedDate As Date) = @Today;
End

---------------------------------------------------------------------------------------------------------------------
--Orders Stored Procedures

------Stored Procedure to add Order
--Returns the new OrderID and daily order count
Create Proc AddOrder
    @CustomerID int,
    @ServerID int,
    @Category Nvarchar(50),
    @Payment Nvarchar(50),
    @TotalItems int,
    @TotalBill Decimal(8,2),
    @OrderID int Output,
    @DailyOrderNumber int Output
As
Begin
    Set Nocount on;
    
    Declare @Today Date = Cast(GetDate() as Date);
    
    -- Get next daily sequence number
    Select @DailyOrderNumber = IsNull(MAX(DailySequence), 0) + 1
    From [Vintage Cafe].[dbo].[Orders]
    Where OrderDate = @Today;
    
    Insert Into Orders (
        CustomerID,
        ServerID,
        OrderDate,
        DailySequence,
        Category,
        Payment,
        TotalItems,
        TotalBill
    )
    Values (
        @CustomerID,
        @ServerID,
        @Today,
        @DailyOrderNumber,
        @Category,
        @Payment,
        @TotalItems,
        @TotalBill
    );
    
    Set @OrderID = Scope_Identity();
End

--Returns complete order information and is used to load it from the SQL to Winforms(DGV)
Create Proc GetOrderData
As
Begin 
Select [OrderID],
      [ServerID],
      [OrderDate],
      [Category],
      [Payment],
      [TotalItems],
      [TotalBill],
      [CustomerID],
      [DailySequence]
  From [Vintage Cafe].[dbo].[Orders]
  Order By [OrderDate] Asc, [OrderID] Asc
 End

 ------------------------------------------------------------------------------------------
 --Daily Summary Stored Procedures

 ------Count of active users
Create Proc GetActiveUsersCount
As
Begin
    Select Count(*) as ActiveUsers 
    From [Vintage Cafe].[dbo].[Users]
    Where Status = 'active'
End

------Count of today's customers 
Create Proc GetTodaysCustomerCount
As
Begin
    Select Count(*) as TodaysCustomers
    From  [Vintage Cafe].[dbo].[Customers]
    Where Cast(CreatedDate as Date) = Cast(GetDate() as Date)
End

-------Today's income
Create Proc GetTodaysIncome
As
Begin
    Select IsNull(Sum(TotalBill), 0) as TodaysIncome
    From  [Vintage Cafe].[dbo].[Orders]
    Where Cast(OrderDate as Date) = Cast(GetDate() as Date)
End

-------Weekly income
Create Proc GetWeeklyIncome
As
Begin
    Select IsNull(Sum(TotalBill), 0) as WeeklyIncome
    From  [Vintage Cafe].[dbo].[Orders]
    Where OrderDate >= DateAd(Day, -7, Cast(GetDate() as Date))
END

------For automatic daily tracking
Create Proc UpdateDailySummary
As
Begin
    Declare @Today Date = Cast(GetDate() as Date);
    
    If Exists (Select 1 From DailySummary Where SummaryDate = @Today)
    Begin
        Update DailySummary
        Set 
            TotalCustomers = (Select Count(*) 
				From  [Vintage Cafe].[dbo].[Customers]
				Where Cast(CreatedDate as Date) = @Today),

            DailyRevenue = (Select IsNull(Sum(TotalBill), 0) 
				From  [Vintage Cafe].[dbo].[Orders] 
				Where Cast(OrderDate as Date) = @Today),

            LastUpdated = GetDate()
        Where SummaryDate = @Today;
    End
    Else
    Begin
        Insert Into DailySummary (SummaryDate, TotalCustomers, DailyRevenue)
        Select 
            @Today,
            (Select Count(*) 
				From  [Vintage Cafe].[dbo].[Customers]
				Where Cast(CreatedDate as Date) = @Today),

            (Select IsNull(Sum(TotalBill), 0) 
				From  [Vintage Cafe].[dbo].[Orders]
				Where Cast(OrderDate as Date) = @Today);
    End
End

--------------------------------------------------------------------------------------------------------------
--Cashier Performance Stored Procedures

------- Gets today's performance stats for specific cashier
Create Proc GetCashierTodayStats
    @CashierID int
As
Begin
    Select
        IsNull(Sum(CustomersServed), 0) as CustomersServed,
        IsNull(Sum(DailySales), 0) as DailySales
    From CashierPerformance
    Where UserID = @CashierID
    And PerformanceDate = Cast(GetDate() as Date)
End

--Gets weekly performance stats for specific cashier
Create Proc GetCashierWeeklyStats
     @CashierID int
As
Begin
    Select
        IsNull(Sum(CustomersServed), 0) as CustomersServed,
        IsNull(Sum(DailySales), 0) as DailySales
    From CashierPerformance
    Where UserID = @CashierID
    And PerformanceDate >= DateAdd(Day, -7, Cast(GetDate() as Date))
End

--Counts all customers served today (all cashiers)
Create Proc GetTodaysTotalCustomers
As
Begin
    Select Count(*) as TotalCustomers
    From Customers
    Where Cast(CreatedDate as Date) = Cast(GetDate() as Date)
End

--Updates cashier performance metrics when order completes
Create Proc UpdateCashierPerformance
    @CashierID int
As
Begin
    Declare @Today Date = Cast(GetDate() as Date);
    
    --Calculate today's stats for this cashier
    Declare @CustomersServed int, @DailySales Decimal(12,2);
    
    Select
        @CustomersServed = Count(*),
        @DailySales = IsNull(Sum(TotalBill), 0)
    From Orders
    Where ServerID = @CashierID
    And Cast(OrderDate as Date) = @Today;
    
    -- Update or insert performance record
    If Exists (Select 1 From CashierPerformance 
              Where UserID = @CashierID AND PerformanceDate = @Today)
    Begin
        Update CashierPerformance
        Set 
            CustomersServed = @CustomersServed,
            DailySales = @DailySales
        Where UserID = @CashierID AND PerformanceDate = @Today;
    End
    Else
    Begin
        Insert Into CashierPerformance (UserID, PerformanceDate, CustomersServed, DailySales)
        Values (@CashierID, @Today, @CustomersServed, @DailySales);
    End
End

---------------------------------------------------------------------------------------------------------------------
--Currently not in use

--Stored Procedure to get the next user id to show in the form
 Create Proc GetNextUserID
As
Begin
    Select Ident_Current('Users') + Ident_Incr('Users') As NextUserID
End


--Stored Procedure to Retrieve Itemss Data from SQL to the App
Create Proc GetAllItems
As
Select ItemID, ItemName, Category, Price, ItemPic From MenuItems;


--Stored Procedure to Delete Items
Create Proc DeleteItem 
@ItemID int
As
Delete From MenuItems 
Where ItemID = @ItemID;


-- Load single item for update
Create Proc GetItem @ItemID int
As
Select ItemID, ItemName, Category, Price, ItemPic From MenuItems Where ItemID = @ItemID;


--Stored Procedure to get the next item id to show in the form
 Create Proc GetNextItemID
As
Begin
    Select Ident_Current('MenuItems') + Ident_Incr('MenuItems') As NextItemID
End
---------------------------------------------------------------------------------------------------------------------