CREATE PROCEDURE [dbo].[spPaymentDetails_GetAll]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, EmployeeId, BankName, AccountNumber, AccountType, PaymentMethod
    FROM [dbo].[PaymentDetail];
END
