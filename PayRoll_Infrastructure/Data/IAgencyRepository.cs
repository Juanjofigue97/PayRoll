using PayRollApplication.ModelsView.Agencies;
using PayRollLibrary.Entities.Agencies;

namespace PayRoll_Infrastructure.Data;

public interface IAgencyRepository
{
    Task<List<AgencyModel>?> GetAllAgencies();
    Task<AgencyModel?> GetAgencyByID(int agencyId);
    Task InsertAgency(AgencyModel agency);
    Task DeleteAgency(int agencyId);
    Task UpdateAgency(AgencyModel agency);
    Task<List<BranchModel>?> GetAllBranches();
    Task<BranchModel?> GetBranchByID(int branchId);
    Task InsertBranch(BranchModel branch);
    Task DeleteBranch(int branchId);
    Task UpdateBranch(BranchModel branch);
    Task<BranchModelView?> DetailViewBranch(int branchId);
    Task<List<BranchModelView>?> GetAllDetailViewBranches();
}