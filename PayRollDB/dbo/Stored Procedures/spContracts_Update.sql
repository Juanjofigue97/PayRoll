CREATE PROCEDURE [dbo].[spContracts_Update]
    @id int, 
    @name varchar(50),
    @description varchar(50)
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.ContractTypes
    SET Name = @name, Description = @description
    WHERE Id = @id;
END
