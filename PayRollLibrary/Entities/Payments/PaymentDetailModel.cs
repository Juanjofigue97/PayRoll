using System.ComponentModel.DataAnnotations;

namespace PayRollLibrary.Entities.Payments;

public class PaymentDetailModel
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    [MaxLength(50)]
    public string? BankName { get; set; }

    [MaxLength(50)]
    public string? AccountNumber { get; set; }

    [MaxLength(50)]
    public string? AccountType { get; set; }

    [MaxLength(50)]
    public string? PaymentMethod { get; set; }
}
