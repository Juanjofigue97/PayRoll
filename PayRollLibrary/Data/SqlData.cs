using PayRollLibrary.Databases;
using PayRollLibrary.Models.Agencies;

namespace PayRollLibrary.Data;

public class SqlData : ISqlData
{
    private readonly IDataAccess _db;
    private const string connectionString = "";
    public SqlData(IDataAccess db)
    {
        _db = db;
    }

    public List<AgencyModel> GetAgencies()
    {
        string sql = "dbo.spAgencies_GetAll";
        return _db.LoadData<AgencyModel, dynamic>(sql,
                                                  new { },
                                                  connectionString,
                                                  new { IsStoedProcedure = true });
    }
}
