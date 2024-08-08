CREATE PROCEDURE [dbo].[spBranches_GetAllDetailView]
AS
begin
	set nocount on;

	select b.*, a.Name as AgencyName
	from dbo.Branches b
	join dbo.Agencies a on a.Id = b.AgencyId  

end
