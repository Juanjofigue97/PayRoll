CREATE PROCEDURE [dbo].[spPaymentDetails_GetAllDetailView]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.*, 
    (e.LastName + ' ' + e.SecondSurname + ' ' + e.FirstName + ' ' + e.MiddleName) as EmployeeName
    FROM dbo.PaymentDetail p
    JOIN dbo.Employees e ON p.EmployeeId = e.Id
END
