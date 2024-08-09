CREATE PROCEDURE [dbo].[spDocuments_GetById]
    @documentId int
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT *
    FROM dbo.DocumentTypes
    WHERE Id = @documentId;
END
