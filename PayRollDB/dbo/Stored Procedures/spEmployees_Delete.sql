CREATE PROCEDURE [dbo].[spEmployees_Delete]
@id int
AS
begin
	set nocount on;
	
	Delete from dbo.Employees
	where Id = @id;

end