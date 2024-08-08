CREATE PROCEDURE [dbo].[spBranches_GetById]
@branchId int
AS
begin
	set nocount on;
	select Id,Name,Description
	from dbo.Branches where Id = @branchId;
end
