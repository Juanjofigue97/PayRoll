/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists (select 1 from dbo.Agencies)
begin
    insert into dbo.Agencies("Name",Description)
    values('Pasto','Agencia Principal de la Coopetativa'),
    ('Sandona','2'),
    ('Ipiales','3')
end


--if not exists (select 1 from dbo.Branches)
--begin
--    declare @agencyId1 int; 
--    declare @agencyId2 int; 
--    declare @agencyId3 int; 
    
--    select @agencyId1 = Id from dbo.Agencies where Name = 'Pasto' 
--    select @agencyId2 = Id from dbo.Agencies where Name = 'Sandona' 
--    select @agencyId3 = Id from dbo.Agencies where Name = 'Ipiales' 

--    insert into dbo.Branches("Name",Description,AgencyId)
--    values('Pasto','Agencia Principal de la Coopetativa',@agencyId1),
--    ('Chachagui','Extension',@agencyId1),
--    ('Nariño','Extension',@agencyId1),
--    ('Sandona','Agencia',@agencyId2),
--    ('Ipiales','Extension',@agencyId3)
--end