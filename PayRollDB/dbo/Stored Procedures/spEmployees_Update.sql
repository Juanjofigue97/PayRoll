CREATE PROCEDURE [dbo].[spEmployees_Update]
    @employeeId int,
    @documentId int,
    @document varchar(50),
    @lastName varchar(50),
    @secondSurname varchar(50),
    @firstName varchar(50),
    @middleName varchar(50),
    @baseSalary decimal(18,2),
    @contractId int,
    @branchId int,
    @positionId int,
    @photo varchar(50),
    @isValid bit
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.Employees
    SET 
        DocumentTypeId = @documentId,
        Document = @document,
        LastName = @lastName,
        SecondSurname = @secondSurname,
        FirstName = @firstName,
        MiddleName = @middleName,
        BaseSalary = @baseSalary,
        ContractTypeId = @contractId,
        BranchId = @branchId,
        PositionId = @positionId,
        Photo = @photo,
        IsValid = @isValid
    WHERE Id = @employeeId;
END
