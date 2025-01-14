using Microsoft.AspNetCore.Http;

namespace TechnicalIssueHandler.BL.ViewModels.EmployeeVMs;

public class EmployeeGetVM
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public IFormFile Image { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Salary { get; set; }
    public string DesignationName { get; set; }
}