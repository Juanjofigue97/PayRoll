﻿CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[DocumentTypeId] INTEGER,
	[Document] VARCHAR(50),
	[LastName] VARCHAR(50),
	[SecondSurname] VARCHAR(50),
	[FirstName] VARCHAR(50),
	[MiddleName] VARCHAR(50),
	[BaseSalary] MONEY,
	[ContractTypeId] INTEGER,
	[BranchId] INTEGER,
	[PositionId] INTEGER,
	[CreationDate] DATETIME2,
	[Photo] VARCHAR(50),
	[IsValid] TINYINT, 
    CONSTRAINT [FK_Employees_DocumentTypes] FOREIGN KEY (DocumentTypeId) REFERENCES DocumentTypes(Id),
    CONSTRAINT [FK_Employees_ContractTypes] FOREIGN KEY (ContractTypeId) REFERENCES DocumentTypes(Id),
    CONSTRAINT [FK_Employees_Branches] FOREIGN KEY (BranchId) REFERENCES Branches(Id),
    CONSTRAINT [FK_Employees_Positions] FOREIGN KEY (PositionId) REFERENCES Positions(Id),
)
