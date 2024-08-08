CREATE PROCEDURE [dbo].[spBranches_Update]
@id int, 
@name varchar(50),
@description varchar(50),
@agencyId int

AS
begin
	set nocount on;
	
	UPDATE dbo.Branches
	SET Name = @name, Description = @description , AgencyId = @agencyId
	WHERE Id = @id;

end
