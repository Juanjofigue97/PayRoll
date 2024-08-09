CREATE PROCEDURE [dbo].[spContracts_GetAll]

AS
begin
	set nocount on;

	select *
	from dbo.ContractTypes

end
