# Vintage Cafe

A desktop ordering system for a small cafe, built with C# Windows Forms and SQL Server. Staff sign in as either an admin or a cashier. Cashiers take orders, and admins manage staff, the menu and the day's numbers.

## What it does

**Cashier portal**
- Take dine-in or takeaway orders from the menu
- Record payment by cash, card or mobile payment
- See your own customers served and sales for today and this week

**Admin portal**
- Dashboard with today's income, weekly income, total customers and active staff
- Add, edit and remove staff accounts, including a profile photo, role, salary and status (Active, Inactive or Waiting Approval)
- Add, edit and remove menu items (food or beverage) with a price and photo
- Browse past orders and customers

Only accounts with the status `Active` can sign in.

## Built with

- C# on .NET 9, Windows Forms
- SQL Server, accessed through `Microsoft.Data.SqlClient` and stored procedures
- The [Pixelify Sans](https://fonts.google.com/specimen/Pixelify+Sans) font

## Project layout

```
cafe-proj/
├── Cafe Solution/       Visual Studio solution and the app's source code
├── Vintage Cafe SQL/    Scripts for the tables, stored procedures and trigger
└── Pixelify_Sans/       Font files used by the interface
```

## Getting it running

You need Windows, Visual Studio 2022 (17.12 or later, for .NET 9) and SQL Server with SQL Server Management Studio.

1. Install the Pixelify Sans fonts from `cafe-proj/Pixelify_Sans/static/`. Right-click each `.ttf` file and choose Install. If you skip this, Windows falls back to a default font and the layout will look off.

2. In SSMS, create an empty database called `Vintage Cafe`. Then run the scripts in `cafe-proj/Vintage Cafe SQL/` in this order:
   1. `VC Table Creation.sql`
   2. `VC Stored Procedures.sql`
   3. `VC Triggers.sql`

3. The database starts with no users, so add the first admin by hand:

   ```sql
   USE [Vintage Cafe];
   INSERT INTO Users (FirstName, LastName, Email, Username, Password, Role, Status)
   VALUES ('Admin', 'User', 'admin@example.com', 'admin', 'admin123', 'Admin', 'Active');
   ```

   After you sign in, you can create the other staff accounts from the admin portal.

4. Open `cafe-proj/Cafe Solution/Cafe/app.config` and change `Data Source` to your own SQL Server instance. For a local default instance that's usually `.` or `localhost`, and for SQL Express it's `.\SQLEXPRESS`. The connection uses Windows authentication.

5. Open `cafe-proj/Cafe Solution/Cafe Solution.sln` in Visual Studio and press F5.

## Known limitations

- Passwords are stored in plain text in the `Users` table. Hash them before using this anywhere real.
- The app runs on Windows only, because Windows Forms does.
