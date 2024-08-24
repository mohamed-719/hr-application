using HRApplicationAR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplicationAR.Controllers
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

        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }
        [HttpPost]
        // this method to post to servar(to database)
        public ViewResult Employees(Employee employee)
        {
            // hear we can make Validation to make a sure to inter the empolyee name
            // ModelState is a collection name and value bar to send to sarver 
            if(ModelState.IsValid)
            {
            Repository.AddEmployee(employee);
            return View("ConfirmPage", employee);
            }
            else
            {
                return View();
            }
        }

        public ViewResult AllEmployees()
        {
            return View(Repository.GetEmployee().Where(emp => emp.isActive == true));
        }

    }
}
