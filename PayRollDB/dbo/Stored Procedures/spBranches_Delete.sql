CREATE PROCEDURE [dbo].[spBranches_Delete]
@id int
AS
begin
	set nocount on;
	
	Delete from dbo.Branches
	where Id = @id;

end
