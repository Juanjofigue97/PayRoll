using System.ComponentModel.DataAnnotations;

namespace PayRollLibrary.Entities.Agencies;

public class AgencyModel
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string? Name { get; set; }
    public string? Description { get; set; }

}
