CREATE PROCEDURE [dbo].[spDocuments_Insert]
@name varchar(50),
@description varchar(50)
AS
begin
	set nocount on;
	
	insert into dbo.DocumentTypes (Name,Description)
	Values (@name,@description);

end
