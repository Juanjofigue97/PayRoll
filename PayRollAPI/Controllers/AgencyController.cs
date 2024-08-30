using Microsoft.AspNetCore.Mvc;
using PayRoll_Infrastructure.Data;
using PayRollLibrary.Entities.Agencies;


namespace PayRollAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AgencyController : ControllerBase
{
    private readonly IAgencyRepository _agencyRepository;

    public AgencyController(IAgencyRepository agencyRepository)
    {
        _agencyRepository = agencyRepository;
    }

    [HttpGet("GetAllAgencies")]
    public async Task<ActionResult<IEnumerable<AgencyModel>>?> GetAllAgencies()
    {
        var output = await _agencyRepository.GetAllAgencies();
        return Ok(output);
    }

    [HttpGet("{agencyId}")]
    public async Task<ActionResult<AgencyModel>?> GetAgencyByID(int agencyId)
    {
        var output = await _agencyRepository.GetAgencyByID(agencyId);
        return Ok(output);
    }

    [HttpPost]
    public ActionResult Post([FromBody] AgencyModel agency)
    {
        if (agency.Name is null || agency.Description is null)
        {
            return BadRequest();
        }

        _agencyRepository.InsertAgency(agency);

        return Ok();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] AgencyModel agency)
    {
        _agencyRepository.UpdateAgency(agency);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<AgencyModel>> DeleteAgency(int id)
    {
        try
        {
            var agencyToDelete = await _agencyRepository.GetAgencyByID(id);

            if (agencyToDelete == null)
            {
                return NotFound($"Agency with Id = {id} not found");
            }

            var branches = await _agencyRepository.GetAllBranches();

            var ExistBranch = branches?.Count(x => x.AgencyId == id);

            if (ExistBranch is not null && ExistBranch == 0)
            {
                await _agencyRepository.DeleteAgency(id);
                return Ok($"Agency with Id = {id} has been deleted.");
            }
            else
            {
                return BadRequest($"Agency with Id = {id} have Branches");
            }
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
        }
    }
}
