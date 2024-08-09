CREATE PROCEDURE [dbo].[spDocuments_Update]
    @id int, 
    @name varchar(50),
    @description varchar(50)
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE dbo.DocumentTypes
    SET Name = @name, Description = @description
    WHERE Id = @id;
END
