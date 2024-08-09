CREATE PROCEDURE [dbo].[spDocuments_GetAll]

AS
begin
	set nocount on;

	select *
	from dbo.DocumentTypes

end
