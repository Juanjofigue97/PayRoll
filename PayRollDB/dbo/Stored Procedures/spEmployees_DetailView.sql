CREATE PROCEDURE [dbo].[spEmployees_DetailView]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT e.*, 
           p.Name as PositionName,
           c.Name as ContractTypeName,
           b.Name as BranchName,
           a.Name as AgencyName
    FROM dbo.Employees e
    JOIN dbo.Positions p ON p.Id = e.PositionId
    JOIN dbo.ContractTypes c ON c.Id = e.ContractTypeId
    JOIN dbo.Branches b ON b.Id = e.BranchId
    JOIN dbo.Agencies a ON a.Id = b.AgencyId
END