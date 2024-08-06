CREATE TABLE [dbo].[FixedExpenses]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[EmployeeId] INTEGER,
	[Description] VARCHAR,
	[Amount] DECIMAL,
	[Date] DATETIME2,
	[IsValid] TINYINT,

    CONSTRAINT [FK_FixedExpenses_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),

)
