using PayRollLibrary.Databases;
using PayRollLibrary.Models.Agencies;
using PayRollLibrary.Models.Employees;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PayRollLibrary.Data;

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
                                                      new { IsStoedProcedure = true });
    }

    public async Task DeleteDocument(int DocumentId)
    {
        string sql = "dbo.spDocuments_Delete";
        await _db.LoadDataAsync<AgencyModel, dynamic>(sql,
                                                      new { id = DocumentId },
                                                      connectionString,
                                                      new { IsStoedProcedure = true });
    }

    public async Task DeleteEmployee(int employeeId)
    {
        string sql = "dbo.spEmployees_Delete";
        await _db.LoadDataAsync<AgencyModel, dynamic>(sql,
                                                      new { id = employeeId },
                                                      connectionString,
                                                      new { IsStoedProcedure = true });
    }

    public async Task DeletePosition(int positionId)
    {
        string sql = "dbo.spPositions_Delete";
        await _db.LoadDataAsync<AgencyModel, dynamic>(sql,
                                                      new { id = positionId },
                                                      connectionString,
                                                      new { IsStoedProcedure = true });
    }

    public Task<List<ContractTypesModel>?> GetAllContract()
    {
        throw new NotImplementedException();
    }

    public Task<List<DocumentTypesModel>?> GetAllDocument()
    {
        throw new NotImplementedException();
    }

    public Task<List<EmployeeModel>?> GetAllEmployee()
    {
        throw new NotImplementedException();
    }

    public Task<List<PositionModel>?> GetAllPosition()
    {
        throw new NotImplementedException();
    }

    public Task<ContractTypesModel?> GetContractByID(int contractId)
    {
        throw new NotImplementedException();
    }

    public Task<DocumentTypesModel?> GetDocumentByID(int documentId)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeModel?> GetEmployeeByID(int employeeeId)
    {
        throw new NotImplementedException();
    }

    public Task<PositionModel?> GetPositionByID(int positionId)
    {
        throw new NotImplementedException();
    }

    public Task InsertContract(ContractTypesModel contract)
    {
        throw new NotImplementedException();
    }

    public Task InsertDocument(DocumentTypesModel document)
    {
        throw new NotImplementedException();
    }

    public Task InsertEmployee(EmployeeModel employee)
    {
        throw new NotImplementedException();
    }

    public Task InsertPosition(PositionModel position)
    {
        throw new NotImplementedException();
    }

    public Task UpdateContract(ContractTypesModel contract)
    {
        throw new NotImplementedException();
    }

    public Task UpdateDocument(DocumentTypesModel document)
    {
        throw new NotImplementedException();
    }

    public Task UpdateEmployee(EmployeeModel employee)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePosition(PositionModel position)
    {
        throw new NotImplementedException();
    }
}
