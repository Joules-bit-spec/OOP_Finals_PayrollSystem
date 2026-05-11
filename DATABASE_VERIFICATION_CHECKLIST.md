# 🔧 Database Verification Checklist

Use this checklist to verify your database is set up correctly.

---

## Step 1: Verify Database Exists

**In SQL Server Management Studio or SQL Server Object Explorer:**

1. Connect to `(localdb)\MSSQLLocalDB`
2. Look for database: `Payroll_DB`
3. If not found → Run `Database_Setup.sql` to create it

✅ Database exists

---

## Step 2: Verify Employees Table Exists

**Run this query:**

```sql
SELECT * FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_NAME = 'Employees'
```

**Expected Result**: One row showing the Employees table

✅ Employees table exists

---

## Step 3: Verify Column Names Match (CRITICAL!)

**Run this query to list all columns:**

```sql
SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Employees'
ORDER BY ORDINAL_POSITION
```

**Expected Columns** (in this order):
1. EmployeeID - INT - NOT NULL (Primary Key, Identity)
2. UserID - INT - NOT NULL (Unique)
3. Password - NVARCHAR - NOT NULL
4. FirstName - NVARCHAR - NOT NULL
5. LastName - NVARCHAR - NOT NULL
6. MiddleInitial - NVARCHAR - NULLABLE
7. Gender - NVARCHAR - NULLABLE
8. Birthdate - DATE - NULLABLE
9. Email - NVARCHAR - NULLABLE
10. ContactNo - NVARCHAR - NULLABLE
11. Address - NVARCHAR - NULLABLE
12. Department - NVARCHAR - NULLABLE
13. Position - NVARCHAR - NULLABLE

**⚠️ IMPORTANT**: Column names are **case-insensitive in SQL Server**, but your C# code must match the schema exactly.

If your columns use different names (e.g., `birthDate` instead of `Birthdate`), update the INSERT statement in `Database.cs` to match.

✅ All columns present with correct names

---

## Step 4: Verify Table is Empty

**Run this query:**

```sql
SELECT COUNT(*) as EmployeeCount FROM Employees
```

**Expected Result**: 0 (before any registrations)

✅ Table is empty and ready

---

## Step 5: Verify Database Connection String

**In your code** (`Database.cs` line 13):

```csharp
private readonly string connectionString = 
    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_DB;Integrated Security=True";
```

**Verify**:
- ✅ Data Source: `(localdb)\MSSQLLocalDB`
- ✅ Initial Catalog: `Payroll_DB`
- ✅ Integrated Security: `True`

---

## Step 6: Test Registration

### In the Application:

1. **Click "Register" link** on login form
2. **Fill in test data**:
   - First Name: `Test`
   - Last Name: `User`
   - Middle Initial: `T`
   - Gender: `Male`
   - Birth Date: `01/01/1990`
   - Email: `test@example.com`
   - Contact No: `1234567890`
   - Address: `123 Test St`
   - Department: `Operations`
   - Position: `Service Technician`
   - User ID: `1001`
   - Password: `password123`
3. **Click Register button**
4. **Expected Result**: 
   - Success message showing Employee ID (e.g., "Employee ID: 1")
   - Redirects to Login form

### In SQL Server:

**Run this query** to verify data was inserted:

```sql
SELECT * FROM Employees WHERE UserID = 1001
```

**Expected Result**: One row with all your test data

✅ Registration successful

---

## Step 7: Test Login

### In the Application:

1. **On Login form**, enter:
   - User ID: `1001`
   - Password: `password123`
2. **Click Login button**
3. **Expected Result**:
   - Success message: "Login Successful!"
   - Redirects to Home form

✅ Login successful

---

## Troubleshooting

### Problem: "Invalid column name 'firstName'"
**Cause**: Column names don't match schema
**Solution**:
```sql
-- Check your actual column names
SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Employees'
```
Then update `Database.cs` INSERT statement to match exactly.

---

### Problem: "Cannot find table 'Employees'"
**Cause**: Table doesn't exist
**Solution**: Run `Database_Setup.sql` in SQL Server Management Studio

---

### Problem: "Login fails after registration"
**Cause**: Data not being inserted
**Solution**:
1. Check the error message in the registration error dialog
2. Run in SQL Server: `SELECT * FROM Employees`
3. If empty, then registration isn't working - check column names

---

### Problem: "Login successful but can't access profile"
**Cause**: CurrentUser session not populated
**Solution**: Verify `Login.cs` has the code that populates CurrentUser:
```csharp
CurrentUser.EmployeeID = Convert.ToInt32(result.Rows[0]["EmployeeID"]);
CurrentUser.FirstName = result.Rows[0]["FirstName"].ToString();
CurrentUser.LastName = result.Rows[0]["LastName"].ToString();
CurrentUser.MiddleInit = result.Rows[0]["MiddleInitial"].ToString();
```

---

## Quick Diagnostic Query

**Run this in SQL Server** to see everything at once:

```sql
-- Check database exists
SELECT DB_NAME() as CurrentDatabase

-- Check table exists
SELECT OBJECT_NAME(object_id) as TableName FROM sys.tables WHERE name = 'Employees'

-- Check columns
SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Employees' ORDER BY ORDINAL_POSITION

-- Check data
SELECT COUNT(*) as TotalEmployees FROM Employees
SELECT TOP 5 EmployeeID, UserID, FirstName, LastName FROM Employees
```

---

## Final Checklist

- [ ] Database `Payroll_DB` exists in SQL Server
- [ ] Table `Employees` exists in `Payroll_DB`
- [ ] All 13 columns present with correct names (PascalCase)
- [ ] Table is empty (no data yet)
- [ ] Connection string in `Database.cs` is correct
- [ ] Registration successfully creates employee record
- [ ] Employee data appears in Employees table
- [ ] Login successfully finds employee by UserID/Password
- [ ] Login redirects to Home form
- [ ] CurrentUser session populated after login

---

## If Everything Checks Out ✅

Your application should now:
1. ✅ Register new employees successfully
2. ✅ Store data in Employees table
3. ✅ Login with registered credentials
4. ✅ Access profile and other features with session data

**You're ready to use the application!** 🚀
