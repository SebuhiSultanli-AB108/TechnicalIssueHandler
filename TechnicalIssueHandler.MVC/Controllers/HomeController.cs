using Microsoft.AspNetCore.Mvc;
using TechnicalIssueHandler.BL.Services.DesignationServices;
using TechnicalIssueHandler.BL.Services.EmployeeServices;
using TechnicalIssueHandler.BL.ViewModels.CommonVMs;

namespace TechnicalIssueHandler.MVC.Controllers;

public class HomeController(IEmployeeService _employeeService, IDesignationService _designationService) : Controller
{
    public IActionResult Index()
    {
        return View(new HomeVM()
        {
            Employee = _employeeService.GetAll(),
            Designation =  _designationService.GetAll(),
        });
    }
}