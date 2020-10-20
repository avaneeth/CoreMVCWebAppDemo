using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreMVCWebAppDemo.Models;

namespace CoreMVCWebAppDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }        

        public IActionResult EmployeeEdit()
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.EmployeeCode = "BOB51";
            employeeDetails.EmployeeName = "Jijeesh";
            employeeDetails.EmployeeDesignation = "SM";
            return View(employeeDetails);
        }
        public IActionResult EmployeeDisplay(EmployeeDetails employeeDetails)
        {
            return View(employeeDetails);
        }
       
    }
}
