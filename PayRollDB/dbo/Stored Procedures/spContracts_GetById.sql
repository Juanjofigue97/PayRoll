CREATE PROCEDURE [dbo].[spContracts_GetById]
    @contractId int
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT *
    FROM dbo.ContractTypes
    WHERE Id = @contractId;
END
