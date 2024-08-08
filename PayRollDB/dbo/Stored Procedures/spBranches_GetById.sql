CREATE PROCEDURE [dbo].[spBranches_GetById]
@branchId int
AS
begin
	set nocount on;
	select *
	from dbo.Branches where Id = @branchId;
end
