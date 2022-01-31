using MakonisoftTestApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BAL;

namespace MakonisoftTestApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Employee()
        {
            return View();
        }

        public JsonResult SubmitEmployeeData(Employee employee)
        {
            EmployeeBAL emp = new EmployeeBAL();
            bool result = emp.SaveEmployeeData(employee.FirstName, employee.LastName);
            if (result)
                return Json("Success");
            return Json("Fail");
        }
    }
}