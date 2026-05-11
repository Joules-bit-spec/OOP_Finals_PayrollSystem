-- Create the Payroll_DB database if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Payroll_DB')
BEGIN
    CREATE DATABASE Payroll_DB;
END
GO

-- Use the Payroll_DB database
USE Payroll_DB;
GO

-- Create the Employees table
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Employees]
    (
        [EmployeeID] INT IDENTITY(1,1) PRIMARY KEY,
        [UserID] INT NOT NULL UNIQUE,
        [Password] NVARCHAR(255) NOT NULL,
        [FirstName] NVARCHAR(100) NOT NULL,
        [LastName] NVARCHAR(100) NOT NULL,
        [MiddleInitial] NVARCHAR(10),
        [Gender] NVARCHAR(50),
        [Birthdate] NVARCHAR(50),
        [Email] NVARCHAR(100),
        [ContactNo] INT,
        [Address] NVARCHAR(255),
        [Department] NVARCHAR(100),
        [Position] NVARCHAR(100),
        [CreatedAt] DATETIME DEFAULT GETDATE(),
        [UpdatedAt] DATETIME DEFAULT GETDATE()
    );
END
GO

-- Create an index on UserID for faster login queries
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Employees_UserID')
BEGIN
    CREATE INDEX [IX_Employees_UserID] ON [dbo].[Employees]([UserID]);
END
GO

-- Display table creation status
SELECT 'Employees table created successfully!' AS Status;
SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Employees';
