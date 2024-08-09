CREATE PROCEDURE [dbo].[spEmployees_Insert]
    @documentId int,
    @document varchar(50),
    @lastName varchar(50),
    @secondSurname varchar(50),
    @firstName varchar(50),
    @middleName varchar(50),
    @baseSalary decimal(18,2),
    @contractId int,
    @branchId int,
    @positionId int

AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO dbo.Employees
           ([DocumentTypeId]
           ,[Document]
           ,[LastName]
           ,[SecondSurname]
           ,[FirstName]
           ,[MiddleName]
           ,[BaseSalary]
           ,[ContractTypeId]
           ,[BranchId]
           ,[PositionId]
           ,[CreationDate]
           ,[Photo]
           ,[IsValid])
     VALUES
           (@documentId
           ,@document
           ,@lastName
           ,@secondSurname
           ,@firstName
           ,@middleName
           ,@baseSalary
           ,@contractId
           ,@branchId
           ,@positionId
           ,GETDATE()
           ,''
           ,1)
END
