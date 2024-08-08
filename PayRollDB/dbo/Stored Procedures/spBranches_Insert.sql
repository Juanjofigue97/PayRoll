CREATE PROCEDURE [dbo].[spBranches_Insert]
@name varchar(50),
@description varchar(50),
@agencyId int

AS
begin
	set nocount on;
	
	insert into dbo.Branches(Name,Description,AgencyId)
	Values (@name,@description,@agencyId);

end
