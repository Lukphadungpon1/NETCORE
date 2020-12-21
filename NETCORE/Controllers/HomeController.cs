using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETCORE.Models;
using Newtonsoft.Json;

namespace NETCORE.Controllers
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
            //var user = new UserAuthentication() { UserId = 1, Username = "Theerayut", Position = "IT" };
            //HttpContext.Session.SetString("Sessionuser", JsonConvert.SerializeObject(user));
            //HttpContext.Session.SetString("TEST", "aaaa");

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUser")))
            {
                var sessionuser = JsonConvert.DeserializeObject<List<UserAuthentication>>(HttpContext.Session.GetString("SessionUser"));
                foreach(var item in sessionuser)
                {
                    ViewBag.Username = item.Username.ToString();
                }
            }
            else
            {
                ViewBag.Username = "";   
            }


            return View();
        }

        public IActionResult Privacy()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUser")))
            {
                var sessionuser = JsonConvert.DeserializeObject<List<UserAuthentication>>(HttpContext.Session.GetString("SessionUser"));
                //var sessoinTest = HttpContext.Session.GetString("TEST");

                ViewBag.UserAuthentication = sessionuser;
               // ViewBag.SessionTest = sessoinTest;
            }
            else
            {
                List<UserAuthentication> sessionuser = new List<UserAuthentication>();
                ViewBag.UserAuthentication = sessionuser;
                ViewBag.SessionTest = "";

                
            }

               


            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
