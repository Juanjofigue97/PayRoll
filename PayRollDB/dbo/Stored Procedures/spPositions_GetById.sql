CREATE PROCEDURE [dbo].[spPositions_GetById]
    @positionId int
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT *
    FROM dbo.Positions
    WHERE Id = @positionId;
END
