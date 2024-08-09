CREATE PROCEDURE [dbo].[spPaymentDetails_Update]
    @Id INT,
    @EmployeeId INT,
    @BankName VARCHAR(50),
    @AccountNumber VARCHAR(50),
    @AccountType VARCHAR(50),
    @PaymentMethod VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[PaymentDetail]
    SET EmployeeId = @EmployeeId, 
        BankName = @BankName, 
        AccountNumber = @AccountNumber, 
        AccountType = @AccountType, 
        PaymentMethod = @PaymentMethod
    WHERE Id = @Id;
END
