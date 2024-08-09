namespace PayRollLibrary.ModelView.Employees;

public class EmployeeViewModel
{
    public int Id { get; set; }
    public int DocumentTypeId { get; set; }
    public string? Document { get; set; }
    public string? LastName { get; set; }
    public string? SecondSurname { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public decimal BaseSalary { get; set; }
    public string? ContractTypeName { get; set; }
    public string? BranchName { get; set; }
    public string? AgencyName { get; set; }
    public string? PositionName { get; set; }
    public DateTime CreationDate { get; set; }
    public string? Photo { get; set; }
    public bool IsValid { get; set; } = true;

    public string? FullName
    {
        get => $"{LastName} {SecondSurname} {FirstName} {MiddleName}";
    }
}
