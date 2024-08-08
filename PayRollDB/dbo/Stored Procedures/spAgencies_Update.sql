CREATE PROCEDURE [dbo].[spAgencies_Update]
@id int, 
@name varchar(50),
@description varchar(50)
AS
begin
	set nocount on;
	
	UPDATE dbo.Agencies
	SET Name = @name, Description = @description
	WHERE Id = @id;

end
