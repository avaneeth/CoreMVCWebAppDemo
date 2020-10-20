using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCWebAppDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCWebAppDemo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Validation(LoginDetails loginDetails)
        {
            if(loginDetails.Password=="abcd@1234"&& loginDetails.UserID=="Jijeesh")
                return View(loginDetails);
            else return View("Index");
        }
    }
}
