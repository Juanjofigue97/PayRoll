CREATE PROCEDURE [dbo].[spPaymentDetails_GetById]
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, EmployeeId, BankName, AccountNumber, AccountType, PaymentMethod
    FROM [dbo].[PaymentDetail]
    WHERE Id = @Id;
END
