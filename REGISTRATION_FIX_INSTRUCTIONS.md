# Fix Registration Error - Complete Guide

## Error Analysis
**Error Message:** `Error registering employee: Database error during registration: Invalid object name 'Employees'.`

**Root Cause:** The `Employees` table does not exist in your `Payroll_DB` database.

---

## Solution Steps

### Step 1: Create the Database Schema

1. **Open SQL Server Management Studio (SSMS)**
   - Connect to `(localdb)\MSSQLLocalDB`

2. **Open the Database_Setup.sql file**
   - File location: `OOP_Finals_PayrollSystem\Database_Setup.sql`

3. **Run the SQL Script**
   - Select all the SQL code
   - Click "Execute" or press `Ctrl+E`
   - You should see: `Employees table created successfully!`

### Step 2: Verify the Table Was Created

Run this verification query in SSMS:

```sql
USE Payroll_DB;
SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Employees';
```

You should see one row with:
- `TABLE_CATALOG`: Payroll_DB
- `TABLE_NAME`: Employees
- `TABLE_SCHEMA`: dbo

### Step 3: Test the Registration

1. Rebuild your Visual Studio project
   - Press `Ctrl+Shift+B` or go to Build → Rebuild Solution

2. Run the application

3. Try registering a new employee with test data:
   - First Name: TestFirst
   - Last Name: TestLast
   - Middle Initial: T
   - Gender: Male
   - Birthdate: Any date
   - Email: test@example.com
   - Contact: 1234567890
   - Address: 123 Test Street
   - Department: Operations
   - Position: Service Technician
   - User ID: 1001
   - Password: test123

---

## What Was Fixed

### Database Schema
The SQL script creates the `Employees` table with the following structure:

| Column | Type | Notes |
|--------|------|-------|
| EmployeeID | INT IDENTITY | Primary Key, Auto-increment |
| UserID | INT | Unique identifier for login |
| Password | NVARCHAR(255) | Encrypted password |
| FirstName | NVARCHAR(100) | Employee first name |
| LastName | NVARCHAR(100) | Employee last name |
| MiddleInitial | NVARCHAR(10) | Middle initial |
| Gender | NVARCHAR(50) | Employee gender |
| Birthdate | NVARCHAR(50) | Birth date |
| Email | NVARCHAR(100) | Email address |
| ContactNo | INT | Contact number |
| Address | NVARCHAR(255) | Physical address |
| Department | NVARCHAR(100) | Department name |
| Position | NVARCHAR(100) | Job position |
| CreatedAt | DATETIME | Record creation timestamp |
| UpdatedAt | DATETIME | Record update timestamp |

### Code Status
✅ **Database.cs** - Already has correct column names (PascalCase)
✅ **Login.cs** - Already queries Employees table correctly
✅ **Registration.cs** - Correctly passes employee data

---

## Troubleshooting

### Issue: SQL Server Management Studio not installed
**Solution:** 
- Download and install from: https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms
- Or use Visual Studio's built-in SQL Server Object Explorer

### Issue: Database not found after running SQL
**Solution:**
1. Verify the connection string in `Database.cs`:
   ```csharp
   private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_DB;Integrated Security=True";
   ```

2. Check that you ran the SQL script in the correct database instance

### Issue: Still getting "Invalid object name" error
**Solution:**
1. Close Visual Studio
2. Run SQL script again to recreate the table
3. Rebuild the solution
4. Restart Visual Studio

---

## Prevention for Future Issues

1. **Always run SQL schema setup first** before running the application for the first time
2. **Version control the SQL script** (already in your repository now)
3. **Document database requirements** in your README.md
4. **Use database migrations** (consider using Entity Framework migrations for future projects)

---

## Additional Security Notes

⚠️ **Important:** The current code stores passwords in plain text. For production, consider:
1. Using bcrypt or similar hashing algorithms
2. Encrypting passwords before storing
3. Never logging passwords
4. Implementing proper authentication frameworks
