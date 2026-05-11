# Registration & Login Issues - Root Cause Analysis

## Issues Found ❌

### 1. **CRITICAL: SQL Column Name Mismatch** 🔴

**Problem Location**: `Database.cs` Line 24

**The Issue**:
The SQL INSERT statement uses lowercase column names, but SQL Server likely created them with PascalCase (standard convention).

```sql
-- WRONG (what the code is trying)
INSERT INTO Employees (userID, passWord, firstName, lastName, middleInit, gender, birthDate, email, contactNo, address, department, position)

-- CORRECT (what SQL Server expects)
INSERT INTO Employees (UserID, Password, FirstName, LastName, MiddleInitial, Gender, Birthdate, Email, ContactNo, Address, Department, Position)
```

**Why It Fails**:
- SQL Server throws "Invalid column name" error
- Code catches SqlException and wraps it as generic Exception
- User sees: "Database error during registration: Invalid column name 'firstName'"

---

### 2. **Column Name Mismatch: birthDate vs Birthdate** 🟠

**Problem**: 
- C# uses: `birthDate`
- SQL likely uses: `Birthdate`

**Impact**: Registration fails when inserting birth date

---

### 3. **Column Name Mismatch: middleInit vs MiddleInitial** 🟠

**Problem**:
- C# uses: `middleInit`
- SQL likely uses: `MiddleInitial`

**Impact**: Middle initial not inserted correctly

---

### 4. **Column Name Mismatch: passWord vs Password** 🟠

**Problem**:
- C# uses: `passWord`
- SQL likely uses: `Password`

**Impact**: Password not inserted correctly

---

### 5. **Login Queries Wrong Table** 🔴

**Problem Location**: `Login.cs` Line 41

```csharp
string query = "SELECT * FROM Users WHERE UserID = @UserID AND Password = @Password";
```

**The Issue**:
Login is querying the `Users` table, but registration inserts into `Employees` table. The `Users` table might not be populated!

**Should be**:
```csharp
string query = "SELECT * FROM Employees WHERE UserID = @UserID AND Password = @Password";
```

---

## Solution

### Step 1: Fix Database.cs Column Names

Replace line 24 with correct column names:

```csharp
var command = new SqlCommand(
    "INSERT INTO Employees (UserID, Password, FirstName, LastName, MiddleInitial, Gender, Birthdate, Email, ContactNo, Address, Department, Position) " +
    "VALUES (@userID, @passWord, @firstName, @lastName, @middleInit, @gender, @birthDate, @email, @contactNo, @address, @department, @position); " +
    "SELECT SCOPE_IDENTITY();", 
    connection
);
```

**Key Changes**:
- `userID` → `UserID`
- `passWord` → `Password`
- `firstName` → `FirstName`
- `lastName` → `LastName`
- `middleInit` → `MiddleInitial`
- `gender` → `Gender`
- `birthDate` → `Birthdate`
- `email` → `Email`
- `contactNo` → `ContactNo`
- `address` → `Address`
- `department` → `Department`
- `position` → `Position`

---

### Step 2: Fix Login.cs to Query Employees Table

Replace line 41:

```csharp
// BEFORE
string query = "SELECT * FROM Users WHERE UserID = @UserID AND Password = @Password";

// AFTER
string query = "SELECT * FROM Employees WHERE UserID = @UserID AND Password = @Password";
```

---

## Why This Happened

When the database was created with `Database_Setup.sql`, the table columns were likely defined with PascalCase naming convention (standard for SQL Server):

```sql
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,           -- PascalCase
    Password NVARCHAR(50) NOT NULL, -- PascalCase
    FirstName NVARCHAR(50),         -- PascalCase
    LastName NVARCHAR(50),
    MiddleInitial NVARCHAR(1),      -- NOT middleInit
    Gender NVARCHAR(10),
    Birthdate DATE,                 -- NOT birthDate
    -- etc.
);
```

But the C# code was using camelCase (`userID`, `passWord`) when it should have used PascalCase to match SQL column names.

---

## Expected Behavior After Fixes

1. **Registration**:
   ✅ User fills form with all data
   ✅ Clicks Register
   ✅ Data inserts into `Employees` table with correct column mapping
   ✅ EmployeeID returned and shown in success message
   ✅ User redirected to Login form

2. **Login**:
   ✅ User enters UserID and Password
   ✅ Query searches `Employees` table (not empty `Users` table)
   ✅ Credentials matched successfully
   ✅ User logged in and redirected to Home form

---

## Testing Checklist

- [ ] Fix Database.cs column names (line 24)
- [ ] Fix Login.cs table name (line 41)
- [ ] Rebuild solution
- [ ] Register new employee (watch for error messages)
- [ ] Check if employee appears in database
- [ ] Login with registered credentials
- [ ] Verify you reach Home form

---

## Additional Notes

⚠️ **Important**: The exact column names depend on how your `Employees` table was created. 

**To verify your actual column names**, run this in SQL Server:

```sql
SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Employees'
ORDER BY ORDINAL_POSITION;
```

This will show you exactly what column names exist in your table, so you can match them precisely in the C# code.
