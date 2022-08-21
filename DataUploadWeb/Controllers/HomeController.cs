using DataUploadWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataUploadWeb.Controllers
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
            var empList = new List<Employee>();

            for (int i = 0; i < 100000; i++)
            {
                empList.Add(new() { Id = i, Name = $"Very Long Emp{i} Name Of Many Characters", DOJ = DateTime.Now.AddDays(-i)});
            }

            return View(empList);
        }

        [HttpPost]
        [Consumes("application/json")]
        public IActionResult PostDataTest([FromBody] Employee[] employees)
        {
            return Json(employees);
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
    }
}