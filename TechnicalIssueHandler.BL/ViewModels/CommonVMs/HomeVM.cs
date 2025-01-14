using TechnicalIssueHandler.BL.ViewModels.DesigantionVMs;
using TechnicalIssueHandler.BL.ViewModels.EmployeeVMs;

namespace TechnicalIssueHandler.BL.ViewModels.CommonVMs;

public class HomeVM
{
    public IEnumerable<DesignationGetVM> Designation;
    public IEnumerable<EmployeeGetVM> Employee;
}
