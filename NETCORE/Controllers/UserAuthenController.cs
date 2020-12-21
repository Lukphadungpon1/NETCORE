using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NETCORE.Models;
using NETCORE.Models.DB;
using Newtonsoft.Json;
using System.Text.Json;

namespace NETCORE.Controllers
{
    public class UserAuthenController : Controller
    {
        KPIContext db = new KPIContext();

        public IActionResult Index()
        {
            
              
            return View();
        }

        [HttpPost]
        public IActionResult Index(string uname, string pswd)
        {

            //var user = new UserAuthentication() { UserId = 1, Username = "Theerayut", Position = "IT" };
            //HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));

            var result =  db.GetLoginByUsernamePassword.FromSqlRaw("exec [dbo].[WEB_UserLogin] '"+ uname  + "','" + pswd + "'").ToList();

            if (result.Count > 0){
                //List<UserAuthentication> lst = result.Select(s => new UserAuthentication
                //{
                //    UserId = s.Id,
                //    Username = s.Username,
                //    Position = s.Position,
                //    Section = s.Section,
                //    Department = s.Department

                //}).ToList();

                List<UserAuthentication> user = new List<UserAuthentication>();
                foreach(var item in result)
                {
                    user.Add(new UserAuthentication { 
                        UserId = item.Id,
                        Username = item.Username,
                        Position = item.Position,
                        Section = item.Section,
                        Department = item.Department
                    });
                }


                //HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));
                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Name = "Username & Password Incollect...";
                return View();
            }

           
        }

        public  IActionResult Logout()
        {
             HttpContext.Session.Clear();
            return RedirectToAction("Index", "UserAuthen");
        }
    }
}
