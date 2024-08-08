CREATE PROCEDURE [dbo].[spPositions_Delete]
@id int
AS
begin
	set nocount on;
	
	Delete from dbo.Positions
	where Id = @id;

end