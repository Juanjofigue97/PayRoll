using PayRoll_Infrastructure.Databases;
using PayRollApplication.Models.Employees;
using PayRollLibrary.Entities.Agencies;
using PayRollLibrary.Entities.Employees;

namespace PayRoll_Infrastructure.Data;

public class SqlEmployeeRepository : IEmployeeRepository
{
    private readonly IDataAccess _db;
    private const string connectionString = "PayRollBd";
    public SqlEmployeeRepository(IDataAccess db)
    {
        _db = db;
    }
    public async Task DeleteContract(int contractId)
    {
        string sql = "dbo.spContracts_Delete";
        await _db.LoadDataAsync<AgencyModel, dynamic>(sql,
                                                      new { id = contractId },
                                                      connectionString,
                                                      new { IsStoredProcedure = true });
    }

    public async Task DeleteDocument(int DocumentId)
    {
        string sql = "dbo.spDocuments_Delete";
        await _db.SaveDataAsync<dynamic>(sql,
                                         new { id = DocumentId },
                                         connectionString,
                                         new { IsStoredProcedure = true });
    }

    public async Task DeleteEmployee(int employeeId)
    {
        string sql = "dbo.spEmployees_Delete";
        await _db.SaveDataAsync<dynamic>(sql,
                                         new { id = employeeId },
                                         connectionString,
                                         new { IsStoredProcedure = true });
    }

    public async Task DeletePosition(int positionId)
    {
        string sql = "dbo.spPositions_Delete";
        await _db.SaveDataAsync<dynamic>(sql,
                                         new { id = positionId },
                                         connectionString,
                                         new { IsStoredProcedure = true });
    }

    public async Task<List<EmployeeViewModel>?> GetAllDetailViewEmployee()
    {
        string sql = "dbo.spEmployees_DetailView";
        return await _db.LoadDataAsync<EmployeeViewModel, dynamic>(sql,
                                                               new { },
                                                               connectionString,
                                                               new { IsStoredProcedure = true });
    }
    public async Task<List<ContractTypesModel>?> GetAllContract()
    {
        string sql = "dbo.spContracts_GetAll";
        return await _db.LoadDataAsync<ContractTypesModel, dynamic>(sql,
                                                                    new { },
                                                                    connectionString,
                                                                    new { IsStoredProcedure = true });
    }

    public async Task<List<DocumentTypesModel>?> GetAllDocument()
    {
        string sql = "dbo.spDocuments_GetAll";
        return await _db.LoadDataAsync<DocumentTypesModel, dynamic>(sql,
                                                                    new { },
                                                                    connectionString,
                                                                    new { IsStoredProcedure = true });
    }

    public async Task<List<EmployeeModel>?> GetAllEmployee()
    {
        string sql = "dbo.spEmployees_GetAll";
        return await _db.LoadDataAsync<EmployeeModel, dynamic>(sql,
                                                               new { },
                                                               connectionString,
                                                               new { IsStoredProcedure = true });
    }

    public async Task<List<PositionModel>?> GetAllPosition()
    {
        string sql = "dbo.spPositions_GetAll";
        return await _db.LoadDataAsync<PositionModel, dynamic>(sql,
                                                               new { },
                                                               connectionString,
                                                               new { IsStoredProcedure = true });
    }

    public async Task<ContractTypesModel?> GetContractByID(int contractId)
    {
        string sql = "dbo.spContracts_GetById";
        return await _db.FirstValueAsync<ContractTypesModel, dynamic>(sql,
                                                                      new { contractId = contractId },
                                                                      connectionString,
                                                                      new { IsStoredProcedure = true });
    }

    public async Task<DocumentTypesModel?> GetDocumentByID(int documentId)
    {
        string sql = "dbo.spDocuments_GetById";
        return await _db.FirstValueAsync<DocumentTypesModel, dynamic>(
            sql,
            new { documentId = documentId },
            connectionString,
            new { IsStoredProcedure = true }
        );
    }

    public async Task<EmployeeModel?> GetEmployeeByID(int employeeId)
    {
        string sql = "dbo.spEmployees_GetById";
        return await _db.FirstValueAsync<EmployeeModel, dynamic>(sql,
                                                                new { employeeId = employeeId },
                                                                connectionString,
                                                                new { IsStoredProcedure = true });
    }

    public async Task<PositionModel?> GetPositionByID(int positionId)
    {
        string sql = "dbo.spPositions_GetById";
        return await _db.FirstValueAsync<PositionModel, dynamic>(
            sql,
            new { positionId = positionId },
            connectionString,
            new { IsStoredProcedure = true }
        );
    }

    public async Task InsertContract(ContractTypesModel contract)
    {
        string sql = "dbo.spContracts_Insert";
        await _db.SaveDataAsync<dynamic?>(sql,
                                          new { name = contract.Name, description = contract.Description },
                                          connectionString,
                                          new { IsStoredProcedure = true });
    }

    public async Task InsertDocument(DocumentTypesModel document)
    {
        string sql = "dbo.spDocuments_Insert";
        await _db.SaveDataAsync<dynamic?>(sql,
                                          new { name = document.Name, description = document.Description },
                                          connectionString,
                                          new { IsStoredProcedure = true });
    }

    public async Task InsertEmployee(EmployeeModel employee)
    {
        string sql = "dbo.spEmployees_Insert";

        await _db.SaveDataAsync<dynamic?>(sql,
                                          new
                                          {
                                              documentId = employee.DocumentTypeId,
                                              document = employee.Document,
                                              lastName = employee.LastName,
                                              secondSurname = employee.SecondSurname,
                                              firstName = employee.FirstName,
                                              middleName = employee.MiddleName,
                                              baseSalary = employee.BaseSalary,
                                              contractId = employee.ContractTypeId,
                                              branchId = employee.BranchId,
                                              positionId = employee.PositionId
                                          },
                                          connectionString,
                                          new { IsStoredProcedure = true });
    }

    public async Task InsertPosition(PositionModel position)
    {
        string sql = "dbo.spPositions_Insert";
        await _db.SaveDataAsync<dynamic?>(sql,
                                          new { name = position.Name, description = position.Description },
                                          connectionString,
                                          new { IsStoredProcedure = true });
    }

    public async Task UpdateContract(ContractTypesModel contract)
    {
        string sql = "dbo.spContracts_Update";

        await _db.SaveDataAsync<dynamic?>(sql,
                                            new
                                            {
                                                id = contract.Id,
                                                name = contract.Name,
                                                description = contract.Description
                                            },
                                            connectionString,
                                            new { IsStoredProcedure = true });
    }

    public async Task UpdateDocument(DocumentTypesModel document)
    {
        string sql = "dbo.spDocuments_Update";

        await _db.SaveDataAsync<dynamic?>(
            sql,
            new
            {
                id = document.Id,
                name = document.Name,
                description = document.Description
            },
            connectionString,
            new { IsStoredProcedure = true }
        );
    }

    public async Task UpdateEmployee(EmployeeModel employee)
    {
        string sql = "dbo.spEmployees_Update";

        await _db.SaveDataAsync<dynamic?>(sql,
                                new
                                {
                                    employeeId = employee.Id,
                                    documentId = employee.DocumentTypeId,
                                    document = employee.Document,
                                    lastName = employee.LastName,
                                    secondSurname = employee.SecondSurname,
                                    firstName = employee.FirstName,
                                    middleName = employee.MiddleName,
                                    baseSalary = employee.BaseSalary,
                                    contractId = employee.ContractTypeId,
                                    branchId = employee.BranchId,
                                    positionId = employee.PositionId,
                                    photo = employee.Photo ?? string.Empty,
                                    isValid = employee.IsValid
                                },
                                connectionString,
                                new { IsStoredProcedure = true });
    }


    public async Task UpdatePosition(PositionModel position)
    {
        string sql = "dbo.spPositions_Update";

        await _db.SaveDataAsync<dynamic?>(
            sql,
            new
            {
                id = position.Id,
                name = position.Name,
                description = position.Description
            },
            connectionString,
            new { IsStoredProcedure = true }
        );
    }



}
