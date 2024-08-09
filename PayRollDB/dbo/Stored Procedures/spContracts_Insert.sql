CREATE PROCEDURE [dbo].[spContracts_Insert]
@name varchar(50),
@description varchar(50)
AS
begin
	set nocount on;
	
	insert into dbo.ContractTypes(Name,Description)
	Values (@name,@description);

end
