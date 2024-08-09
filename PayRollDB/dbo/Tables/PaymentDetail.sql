CREATE TABLE [dbo].[PaymentDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[EmployeeId] INTEGER,
	[BankName] VARCHAR(50),
	[AccountNumber] VARCHAR(50),
	[AccountType] VARCHAR(50),
	[PaymentMethod] VARCHAR(50), 
    CONSTRAINT [FK_PaymentDetail_Employees] FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),

)
