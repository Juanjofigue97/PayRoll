CREATE TABLE [dbo].[Branches]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50),
	[Description] VARCHAR(50),
	[AgencyId] INTEGER, 
    CONSTRAINT [FK_Branches_Agencies] FOREIGN KEY (AgencyId) REFERENCES Agencies(Id),
)
