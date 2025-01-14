using Microsoft.AspNetCore.Mvc;
using TechnicalIssueHandler.BL.Services.EmployeeServices;

namespace TechnicalIssueHandler.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmployeeController(IEmployeeService _service) : Controller
    {
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }
    }
}
