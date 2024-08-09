CREATE PROCEDURE [dbo].[spPaymentDetails_Delete]
    @id INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM [dbo].[PaymentDetail]
    WHERE Id = @id;
END
