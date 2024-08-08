CREATE PROCEDURE [dbo].[spAgencies_Insert]
@name varchar(50),
@description varchar(50)
AS
begin
	set nocount on;
	
	insert into dbo.Agencies (Name,Description)
	Values (@name,@description);

end
