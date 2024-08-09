CREATE PROCEDURE [dbo].[spPositions_GetAll]

AS
begin
	set nocount on;

	select *
	from dbo.Positions

end
