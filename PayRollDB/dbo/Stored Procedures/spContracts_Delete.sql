CREATE PROCEDURE [dbo].[spContracts_Delete]
@id int
AS
begin
	set nocount on;
	
	Delete from dbo.ContractTypes
	where Id = @id;

end
