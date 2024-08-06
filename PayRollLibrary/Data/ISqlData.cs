using PayRollLibrary.Models.Agencies;

namespace PayRollLibrary.Data
{
    public interface ISqlData
    {
        List<AgencyModel> GetAgencies();
    }
}