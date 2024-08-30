using System.ComponentModel.DataAnnotations;

namespace PayRollApplication.Models.Payments;

public class PaymentDetailViewModel
{
    public int Id { get; set; }

    public string? EmployeeName { get; set; }

    [MaxLength(50)]
    public string? BankName { get; set; }

    [MaxLength(50)]
    public string? AccountNumber { get; set; }

    [MaxLength(50)]
    public string? AccountType { get; set; }

    [MaxLength(50)]
    public string? PaymentMethod { get; set; }
}
