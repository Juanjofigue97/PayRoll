CREATE PROCEDURE [dbo].[spBranches_DetailView]
@branchId int
AS
begin
	set nocount on;
	select b.*, a.Name as AgencyName
	from dbo.Branches b
	join dbo.Agencies a on a.Id = b.AgencyId  
	where b.Id = @branchId;
end
