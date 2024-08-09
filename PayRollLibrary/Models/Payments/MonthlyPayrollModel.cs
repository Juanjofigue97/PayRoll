using PayRollLibrary.Models.Employees;

namespace PayRollLibrary.Models.Payments;

public class MonthlyPayrollModel
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? EarnedId { get; set; }

    public int? DeductedId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public decimal? Total { get; set; }

    // Navigation properties (optional)
    public EmployeeModel? Employee { get; set; }
    public EarnedModel? Earned { get; set; }
    public DeductedModel? Deducted { get; set; }
}
