using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollLibrary.Models.Payments;

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
