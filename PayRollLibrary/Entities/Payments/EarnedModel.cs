namespace PayRollLibrary.Entities.Payments;

public class EarnedModel
{
    public int Id { get; set; }
    public int? EmployeeId { get; set; }
    public decimal? Commission { get; set; }
    public decimal? TransportationAllowance { get; set; }
    public int? Days { get; set; }
    public decimal? BasicTotal { get; set; }
    public string? EarnedTotal { get; set; }
}
