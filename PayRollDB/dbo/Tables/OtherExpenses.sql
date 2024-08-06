CREATE TABLE [dbo].[OtherExpenses]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[EmployeeId] INTEGER,
	[Description] VARCHAR(200),
	[Amount] DECIMAL,
	[Date] DATETIME2,

    CONSTRAINT [FK_OtherExpenses_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
)
