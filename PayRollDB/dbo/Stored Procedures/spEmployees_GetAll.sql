CREATE PROCEDURE [dbo].[spEmployees_GetAll]

AS
begin
	set nocount on;

	select *
	from dbo.Employees

end
