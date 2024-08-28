using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PayRollLibrary.Data;
using PayRollLibrary.Models.Agencies;


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

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
