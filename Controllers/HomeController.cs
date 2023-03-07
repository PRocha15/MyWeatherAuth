using Microsoft.AspNetCore.Mvc;
using MyWeatherAuth.Models;
using System.Diagnostics;

namespace MyWeatherAuth.Controllers
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
        public IActionResult Validation(string email, string password)
        {
            //ViewBag.Email = email;
            //ViewBag.Password = password;

            //if (email != null && password != null)
            
                //email: superMan@super.com; pass: "helloworld"
                if (email == "superMan@super.com" && password == "123")
                {
                    return View("Main");

                }
                else
                {
                    ViewData["auth_error"] = "erro";
                    return View("Index");
                   

                }
            
            //else
            //{
            //    return View("");
            //    //ViewBag.Error = "Invalid file name or file path";
            //    //RedirectToAction("Index");

            //}
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}