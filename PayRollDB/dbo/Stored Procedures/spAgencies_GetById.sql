CREATE PROCEDURE [dbo].[spAgencies_GetById]
@agencyId int
AS
begin
	set nocount on;
	select Id,Name,Description
	from dbo.Agencies where Id = @agencyId;
end
