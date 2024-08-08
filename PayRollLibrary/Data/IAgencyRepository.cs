using PayRollLibrary.Models.Agencies;

namespace PayRollLibrary.Data
{
    public interface IAgencyRepository
    {
        Task<List<AgencyModel>?> GetAllAgencies();
        Task<AgencyModel?> GetAgencyByID(int agencyId);
        Task InsertAgency(AgencyModel agency);
        Task DeleteAgency(int agencyId);
        Task UpdateAgency(AgencyModel agency);
        Task<List<BranchModel>?> GetAllBranches();
        Task<BranchModel?> GetBranchByID(int agencyId);
        Task InsertBranch(BranchModel agency);
        Task DeleteBranch(int agencyId);
        Task UpdateBranch(BranchModel agency);
    }
}