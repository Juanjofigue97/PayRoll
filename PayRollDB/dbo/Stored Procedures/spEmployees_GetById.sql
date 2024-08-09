CREATE PROCEDURE [dbo].[spEmployees_GetById]
    @employeeId int
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT *
    FROM dbo.Employees
    WHERE Id = @employeeId;
END