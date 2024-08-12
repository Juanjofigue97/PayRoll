using PayRollLibrary.Models.Payments;
using PayRollLibrary.ModelView.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollLibrary.Data;

public interface IPaymentRepository
{
    // PaymentDetail CRUD
    Task<List<PaymentDetailModel>?> GetAllPaymentDetails();
    Task<PaymentDetailModel?> GetPaymentDetailByID(int id);
    Task InsertPaymentDetail(PaymentDetailModel paymentDetail);
    Task DeletePaymentDetail(int id);
    Task UpdatePaymentDetail(PaymentDetailModel paymentDetail);

    // Deducted CRUD
    Task<List<DeductedModel>?> GetAllDeducted();
    Task<DeductedModel?> GetDeductedByID(int id);
    Task InsertDeducted(DeductedModel deducted);
    Task DeleteDeducted(int id);
    Task UpdateDeducted(DeductedModel deducted);

    // Earned CRUD
    Task<List<EarnedModel>?> GetAllEarned();
    Task<EarnedModel?> GetEarnedByID(int id);
    Task InsertEarned(EarnedModel earned);
    Task DeleteEarned(int id);
    Task UpdateEarned(EarnedModel earned);

    // FixedExpenses CRUD
    Task<List<FixedExpensesModel>?> GetAllFixedExpenses();
    Task<FixedExpensesModel?> GetFixedExpensesByID(int id);
    Task InsertFixedExpenses(FixedExpensesModel fixedExpenses);
    Task DeleteFixedExpenses(int id);
    Task UpdateFixedExpenses(FixedExpensesModel fixedExpenses);

    // MonthlyPayroll CRUD
    Task<List<MonthlyPayrollModel>?> GetAllMonthlyPayrolls();
    Task<MonthlyPayrollModel?> GetMonthlyPayrollByID(int id);
    Task InsertMonthlyPayroll(MonthlyPayrollModel monthlyPayroll);
    Task DeleteMonthlyPayroll(int id);
    Task UpdateMonthlyPayroll(MonthlyPayrollModel monthlyPayroll);

    // OtherExpenses CRUD
    Task<List<OtherExpensesModel>?> GetAllOtherExpenses();
    Task<OtherExpensesModel?> GetOtherExpensesByID(int id);
    Task InsertOtherExpenses(OtherExpensesModel otherExpenses);
    Task DeleteOtherExpenses(int id);
    Task UpdateOtherExpenses(OtherExpensesModel otherExpenses);
    Task<List<PaymentDetailViewModel?>> GetPaymentDetailViewAll();
}
