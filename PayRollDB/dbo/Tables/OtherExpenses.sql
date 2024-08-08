CREATE TABLE [dbo].[OtherExpenses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[EmployeeId] INTEGER,
	[Description] VARCHAR(200),
	[Amount] DECIMAL,
	[Date] DATETIME2,

    CONSTRAINT [FK_OtherExpenses_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
)
