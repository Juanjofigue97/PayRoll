CREATE TABLE [dbo].[Deducted]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[EmployeeId] INTEGER,
	[EarnedId] INTEGER,
	[Health] MONEY,
	[Pension] MONEY,
	[AccountsReceivable] MONEY,
	[DeductedTotal] MONEY,
	[YearPeriod] INTEGER,
	[MonthPeriod] INTEGER,
	[DayPeriod] INTEGER,
	[DeductedDate] DATETIME2,
	[SolidarityFund] MONEY,

	CONSTRAINT [FK_Deducted_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    CONSTRAINT [FK_Deducted_Earned] FOREIGN KEY (EarnedId) REFERENCES Earned(Id),

)
