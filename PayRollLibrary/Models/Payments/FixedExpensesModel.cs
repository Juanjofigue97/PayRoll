using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollLibrary.Models.Payments;

public class FixedExpensesModel
{
    public int Id { get; set; }
    public int? EmployeeId { get; set; }
    public string? Description { get; set; }
    public decimal? Amount { get; set; }
    public DateTime? Date { get; set; }
    public byte? IsValid { get; set; }

}
