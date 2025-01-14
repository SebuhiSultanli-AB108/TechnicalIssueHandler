using TechnicalIssueHandler.BL.ViewModels.DesigantionVMs;

namespace TechnicalIssueHandler.BL.Services.DesignationServices;

public interface IDesignationService
{
    IEnumerable<DesignationGetVM> GetAll();
    Task<DesignationGetVM> GetByIdAsync(Guid id);
    Task CreateAsync(DesignationCreateVM vm);
    Task DeleteAsync(Guid id);
}