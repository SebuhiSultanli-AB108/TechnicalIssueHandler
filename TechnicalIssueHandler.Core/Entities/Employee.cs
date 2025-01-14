namespace TechnicalIssueHandler.Core.Entities;

public class Employee : AuditableEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string ImageUrl { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Salary { get; set; }
    public int DesignationId { get; set; }
    public Designation Designation { get; set; }
}