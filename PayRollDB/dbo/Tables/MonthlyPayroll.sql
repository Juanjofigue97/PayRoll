CREATE TABLE [dbo].[MonthlyPayroll]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[EmployeeId] INTEGER,
	[EarnedId] INTEGER,
	[DeductedId] INTEGER,
	[Month] TINYINT,
	[Year] TINYINT,
	[Total] MONEY,
    CONSTRAINT [FK_MonthlyPayroll_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    CONSTRAINT [FK_MonthlyPayroll_Earned] FOREIGN KEY (EarnedId) REFERENCES Earned(Id),
)
