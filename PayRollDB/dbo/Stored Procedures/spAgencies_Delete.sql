CREATE PROCEDURE [dbo].[spAgencies_Delete]
@id int
AS
begin
	set nocount on;
	
	Delete from dbo.Agencies
	where Id = @id;

end
