CREATE TABLE [dbo].[PaymentData]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[EmployeeId] INTEGER,
	[BankName] VARCHAR,
	[AccountNumber] VARCHAR,
	[AccountType] VARCHAR,
	[PaymentMethod] VARCHAR, 
    CONSTRAINT [FK_PaymentData_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),

)
