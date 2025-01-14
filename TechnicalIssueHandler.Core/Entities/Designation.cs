namespace TechnicalIssueHandler.Core.Entities;

public class Designation : AuditableEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Employee> Employees { get; set; }
}