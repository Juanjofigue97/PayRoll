using PayRollApplication.Models.Employees;
using PayRollLibrary.Entities.Employees;

namespace PayRollApplication.Interfaces;


public interface IEmployeeRepository
{
    // Contract
    Task<List<ContractTypesModel>?> GetAllContract();
    Task<ContractTypesModel?> GetContractByID(int contractId);
    Task InsertContract(ContractTypesModel contract);
    Task DeleteContract(int contractId);
    Task UpdateContract(ContractTypesModel contract);
    //Documents
    Task<List<DocumentTypesModel>?> GetAllDocument();
    Task<DocumentTypesModel?> GetDocumentByID(int documentId);
    Task InsertDocument(DocumentTypesModel document);
    Task DeleteDocument(int DocumentId);
    Task UpdateDocument(DocumentTypesModel document);
    // Positions
    Task<List<PositionModel>?> GetAllPosition();
    Task<PositionModel?> GetPositionByID(int positionId);
    Task InsertPosition(PositionModel position);
    Task DeletePosition(int positionId);
    Task UpdatePosition(PositionModel position);
    
    // Employees
    Task<List<EmployeeModel>?> GetAllEmployee();
    Task<List<EmployeeViewModel>?> GetAllDetailViewEmployee();

    Task<EmployeeModel?> GetEmployeeByID(int employeeeId);
    Task InsertEmployee(EmployeeModel employee);
    Task DeleteEmployee(int employeeId);
    Task UpdateEmployee(EmployeeModel employee);

}
