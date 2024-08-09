CREATE PROCEDURE [dbo].[spPaymentDetails_Insert]
    @EmployeeId INT,
    @BankName VARCHAR(50),
    @AccountNumber VARCHAR(50),
    @AccountType VARCHAR(50),
    @PaymentMethod VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO [dbo].[PaymentDetail] (EmployeeId, BankName, AccountNumber, AccountType, PaymentMethod)
    VALUES (@EmployeeId, @BankName, @AccountNumber, @AccountType, @PaymentMethod);
    
    --SELECT SCOPE_IDENTITY() AS [InsertedId];
END