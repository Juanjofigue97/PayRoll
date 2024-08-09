using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollLibrary.Models.Payments;

public class DeductedModel
{
    [Key]
    public int Id { get; set; }
    public int? EmployeeId { get; set; }
    public int? EarnedId { get; set; }
    public decimal? Health { get; set; }
    public decimal? Pension { get; set; }
    public decimal? AccountsReceivable { get; set; }
    public decimal? DeductedTotal { get; set; }
    public int? YearPeriod { get; set; }
    public int? MonthPeriod { get; set; }
    public int? DayPeriod { get; set; }
    public DateTime? DeductedDate { get; set; }
    public decimal? SolidarityFund { get; set; }
}
