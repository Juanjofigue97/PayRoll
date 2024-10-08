﻿using PayRoll_Infrastructure.Databases;
using PayRollApplication.ModelsView.Agencies;
using PayRollLibrary.Entities.Agencies;

namespace PayRoll_Infrastructure.Data;

public class SqlAgencyRepository : IAgencyRepository
{
    private readonly IDataAccess _db;
    private const string connectionString = "PayRollBd";
    public SqlAgencyRepository(IDataAccess db)
    {
        _db = db;
    }

    public async Task<List<AgencyModel>?> GetAllAgencies()
    {
        string sql = "dbo.spAgencies_GetAll";
        return await _db.LoadDataAsync<AgencyModel, dynamic>(sql,
                                                  new { },
                                                  connectionString,
                                                  new { IsStoredProcedure = true });
    }

    public async Task<AgencyModel?> GetAgencyByID(int agencyId)
    {
        string sql = "dbo.spAgencies_GetById";
        return await _db.FirstValueAsync<AgencyModel?, dynamic>(sql,
                                                               new { agencyId },
                                                               connectionString,
                                                               new { IsStoredProcedure = true });
    }

    public async Task InsertAgency(AgencyModel agency)
    {
        string sql = "dbo.spAgencies_Insert";
        await _db.SaveDataAsync<dynamic?>(sql,
                                          new { name = agency.Name, description = agency.Description },
                                          connectionString,
                                          new { IsStoredProcedure = true });
    }

    public async Task DeleteAgency(int agencyId)
    {
        string sql = "dbo.spAgencies_Delete";
        await _db.LoadDataAsync<AgencyModel, dynamic>(sql,
                                                      new { id = agencyId },
                                                      connectionString,
                                                      new { IsStoredProcedure = true });
    }

    public async Task UpdateAgency(AgencyModel agency)
    {
        string sql = "dbo.spAgencies_Update";
        await _db.LoadDataAsync<AgencyModel, dynamic>(sql,
                                                      new
                                                      {
                                                          id = agency.Id,
                                                          name = agency.Name,
                                                          description = agency.Description
                                                      },
                                                      connectionString,
                                                      new { IsStoredProcedure = true });
    }

    public async Task<List<BranchModel>?> GetAllBranches()
    {
        string sql = "dbo.spBranches_GetAll";
        return await _db.LoadDataAsync<BranchModel, dynamic>(sql,
                                                  new { },
                                                  connectionString,
                                                  new { IsStoredProcedure = true });
    }

    public async Task<BranchModel?> GetBranchByID(int branchId)
    {
        string sql = "dbo.spBranches_GetById";
        return await _db.FirstValueAsync<BranchModel?, dynamic>(sql,
                                                               new { branchId },
                                                               connectionString,
                                                               new { IsStoredProcedure = true });
    }

    public async Task InsertBranch(BranchModel branch)
    {
        string sql = "dbo.spBranches_Insert";
        await _db.SaveDataAsync<dynamic?>(sql,
                                          new 
                                          { 
                                              name = branch.Name, 
                                              description = branch.Description, 
                                              agencyId = branch.AgencyId 
                                          },
                                          connectionString,
                                          new { IsStoredProcedure = true });
    }

    public async Task DeleteBranch(int branchId)
    {
        string sql = "dbo.spBranches_Delete";
        await _db.LoadDataAsync<BranchModel, dynamic>(sql,
                                                      new { id = branchId },
                                                      connectionString,
                                                      new { IsStoredProcedure = true });
    }

    public async Task UpdateBranch(BranchModel branch)
    {
        string sql = "dbo.spBranches_Update";
        await _db.SaveDataAsync<dynamic>(sql,
                                         new
                                         {
                                             id = branch.Id,
                                             name = branch.Name,
                                             description = branch.Description,
                                             agencyId = branch.AgencyId
                                         },
                                         connectionString,
                                         new { IsStoredProcedure = true });
    }

    public async Task<List<BranchModelView>?> GetAllDetailViewBranches()
    {
        string sql = "dbo.spBranches_GetAllDetailView";
        return await _db.LoadDataAsync<BranchModelView, dynamic>(sql,
                                                  new { },
                                                  connectionString,
                                                  new { IsStoredProcedure = true });
    }
    public async Task<BranchModelView?> DetailViewBranch(int branchId)
    {
        string sql = "dbo.spBranches_DetailView";
        return await _db.FirstValueAsync<BranchModelView, dynamic>(sql,
                                         new{ branchId },
                                         connectionString,
                                         new { IsStoredProcedure = true });
    }
}
