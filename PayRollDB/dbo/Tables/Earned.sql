CREATE TABLE [dbo].[Earned]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[EmployeeId] INTEGER,
	[Commission] MONEY,
	[TransportationAllowance] MONEY,
	[Days] INTEGER,
	[BasicTotal] MONEY,
	[EarnedTotal] VARCHAR,
    CONSTRAINT [FK_Earned_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
)
