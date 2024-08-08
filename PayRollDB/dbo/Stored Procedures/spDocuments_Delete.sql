CREATE PROCEDURE [dbo].[spDocuments_Delete]
@id int
AS
begin
	set nocount on;
	
	Delete from dbo.DocumentTypes
	where Id = @id;

end
