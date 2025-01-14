using TechnicalIssueHandler.BL.ViewModels.EmployeeVMs;

namespace TechnicalIssueHandler.BL.Services.EmployeeServices;

public interface IEmployeeService
{
    IEnumerable<EmployeeGetVM> GetAll();
    Task<EmployeeGetVM> GetByIdAsync(Guid id);
    Task CreateAsync(EmployeeCreateVM vm);
    Task DeleteAsync(Guid id);
}