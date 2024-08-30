namespace PayRollLibrary.Entities.Employees;

public class EmployeeModel
{
    public int Id { get; set; }
    public int DocumentTypeId { get; set; }
    public string? Document { get; set; }
    public string? LastName { get; set; }
    public string? SecondSurname { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public decimal BaseSalary { get; set; }
    public int ContractTypeId { get; set; }
    public int BranchId { get; set; }
    public int PositionId { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public string? Photo { get; set; }
    public bool IsValid { get; set; } = true;

}
