if not exists (select 1 from dbo.Positions) 
begin
    insert into dbo.Positions("Name",Description)
    values('AS','Auxiliar Sistemas'),
    ('AM','Asesor de Microcredito')
end

if not exists (select 1 from dbo.ContractTypes) 
begin
    insert into dbo.ContractTypes("Name",Description)
    values('OP','Por prestancion de Servicio'),
    ('Fijo','Termino Fijo')
end

if not exists (select 1 from dbo.DocumentTypes) 
begin
    insert into dbo.DocumentTypes("Name",Description)
    values('CC','Cedula de Ciudadania'),
    ('TI','Tarjeta de Identidad')
end


if not exists (select 1 from dbo.Employees)
begin
    declare @docuementId int; 
    declare @contractId int; 
    declare @branchId int; 
    declare @positionId int; 
    
    select @docuementId = Id from dbo.DocumentTypes where Name = 'CC'
    select @contractId = Id from dbo.ContractTypes where Name = 'OP'
    select @branchId = Id from dbo.Branches where Name = 'Pasto' 
    select @positionId = Id from dbo.Positions where Name = 'AM' 

    INSERT INTO dbo.Employees
           ([DocumentTypeId]
           ,[Document]
           ,[LastName]
           ,[SecondSurname]
           ,[FirstName]
           ,[MiddleName]
           ,[BaseSalary]
           ,[ContractTypeId]
           ,[BranchId]
           ,[PositionId]
           ,[CreationDate]
           ,[Photo]
           ,[IsValid])
     VALUES
           (@docuementId
           ,'1233188475'
           ,'Figueroa'
           ,'Navarro'
           ,'Juan'
           ,'Jose'
           ,'1500000'
           ,@contractId
           ,@branchId
           ,@positionId
           ,GETDATE()
           ,''
           ,1)
end

