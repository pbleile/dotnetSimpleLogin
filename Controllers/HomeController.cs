using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(RegUser regUser){
            if(ModelState.IsValid){
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpPost("login")]
        public IActionResult Login(LogUser logUser){
            Console.WriteLine("Login");
            if(ModelState.IsValid){
                Console.WriteLine("Login Success");
                return RedirectToAction("Success");
            }
            Console.WriteLine("Login Fail");
            return View("Index");
        }
        [HttpGet("success")]
        public IActionResult Success(){
            return View();
        }
    }
}
