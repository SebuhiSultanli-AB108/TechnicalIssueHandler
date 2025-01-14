using Microsoft.AspNetCore.Mvc;
using TechnicalIssueHandler.BL.Services.DesignationServices;

namespace TechnicalIssueHandler.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DesignationController(IDesignationService _service) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
