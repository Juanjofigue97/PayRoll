CREATE PROCEDURE [dbo].[spAgencies_GetAll]

AS
begin
	set nocount on;

	select *
	from dbo.Agencies

end
