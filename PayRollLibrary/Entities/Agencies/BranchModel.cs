namespace PayRollLibrary.Entities.Agencies;

public class BranchModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int AgencyId { get; set; }
}
