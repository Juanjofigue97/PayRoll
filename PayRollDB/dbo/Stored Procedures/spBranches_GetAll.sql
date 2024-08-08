CREATE PROCEDURE [dbo].[spBranches_GetAll]

AS
begin
	set nocount on;

	select *
	from dbo.Branches

end
