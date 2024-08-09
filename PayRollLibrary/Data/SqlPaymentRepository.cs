using PayRollLibrary.Databases;
using PayRollLibrary.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollLibrary.Data;

public class SqlPaymentRepository : IPaymentRepository
{
    private readonly IDataAccess _db;
    private const string connectionString = "PayRollBd";

    public SqlPaymentRepository(IDataAccess db)
    {
        _db = db;
    }

    public async Task<List<PaymentDetailModel>?> GetAllPaymentDetails()
    {
        string sql = "dbo.spPaymentDetails_GetAll";
        return await _db.LoadDataAsync<PaymentDetailModel, dynamic>(sql,
            new { },
            connectionString,
            new { IsStoredProcedure = true });
    }

    public async Task<PaymentDetailModel?> GetPaymentDetailByID(int id)
    {
        string sql = "dbo.spPaymentDetails_GetById";
        return await _db.FirstValueAsync<PaymentDetailModel?, dynamic>(sql,
            new { id },
            connectionString,
            new { IsStoredProcedure = true });
    }

    public async Task InsertPaymentDetail(PaymentDetailModel paymentDetail)
    {
        string sql = "dbo.spPaymentDetails_Insert";
        await _db.SaveDataAsync<dynamic?>(sql,
            new
            {
                employeeId = paymentDetail.EmployeeId,
                bankName = paymentDetail.BankName,
                accountNumber = paymentDetail.AccountNumber,
                accountType = paymentDetail.AccountType,
                paymentMethod = paymentDetail.PaymentMethod
            },
            connectionString,
            new { IsStoredProcedure = true });
    }

    public async Task DeletePaymentDetail(int id)
    {
        string sql = "dbo.spPaymentDetails_Delete";
        await _db.SaveDataAsync<dynamic?>(sql,
            new { id },
            connectionString,
            new { IsStoredProcedure = true });
    }

    public async Task UpdatePaymentDetail(PaymentDetailModel paymentDetail)
    {
        string sql = "dbo.spPaymentDetails_Update";
        await _db.SaveDataAsync<dynamic?>(sql,
            new
            {
                id = paymentDetail.Id,
                employeeId = paymentDetail.EmployeeId,
                bankName = paymentDetail.BankName,
                accountNumber = paymentDetail.AccountNumber,
                accountType = paymentDetail.AccountType,
                paymentMethod = paymentDetail.PaymentMethod
            },
            connectionString,
            new { IsStoredProcedure = true });
    }


    public Task<List<DeductedModel>?> GetAllDeducted()
    {
        throw new NotImplementedException();
    }

    public Task<DeductedModel?> GetDeductedByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertDeducted(DeductedModel deducted)
    {
        throw new NotImplementedException();
    }

    public Task DeleteDeducted(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateDeducted(DeductedModel deducted)
    {
        throw new NotImplementedException();
    }

    public Task<List<EarnedModel>?> GetAllEarned()
    {
        throw new NotImplementedException();
    }

    public Task<EarnedModel?> GetEarnedByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertEarned(EarnedModel earned)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEarned(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateEarned(EarnedModel earned)
    {
        throw new NotImplementedException();
    }

    public Task<List<FixedExpensesModel>?> GetAllFixedExpenses()
    {
        throw new NotImplementedException();
    }

    public Task<FixedExpensesModel?> GetFixedExpensesByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertFixedExpenses(FixedExpensesModel fixedExpenses)
    {
        throw new NotImplementedException();
    }

    public Task DeleteFixedExpenses(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateFixedExpenses(FixedExpensesModel fixedExpenses)
    {
        throw new NotImplementedException();
    }

    public Task<List<MonthlyPayrollModel>?> GetAllMonthlyPayrolls()
    {
        throw new NotImplementedException();
    }

    public Task<MonthlyPayrollModel?> GetMonthlyPayrollByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertMonthlyPayroll(MonthlyPayrollModel monthlyPayroll)
    {
        throw new NotImplementedException();
    }

    public Task DeleteMonthlyPayroll(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateMonthlyPayroll(MonthlyPayrollModel monthlyPayroll)
    {
        throw new NotImplementedException();
    }

    public Task<List<OtherExpensesModel>?> GetAllOtherExpenses()
    {
        throw new NotImplementedException();
    }

    public Task<OtherExpensesModel?> GetOtherExpensesByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertOtherExpenses(OtherExpensesModel otherExpenses)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOtherExpenses(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOtherExpenses(OtherExpensesModel otherExpenses)
    {
        throw new NotImplementedException();
    }
}
