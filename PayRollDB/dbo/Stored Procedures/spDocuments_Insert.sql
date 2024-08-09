CREATE PROCEDURE [dbo].[spPositions_Insert]
@name varchar(50),
@description varchar(50)
AS
begin
	set nocount on;
	
	insert into dbo.Positions(Name,Description)
	Values (@name,@description);

end
