using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NETCORE.DBContext;
using NETCORE.Migrations;
using NETCORE.Models;
using NETCORE.Models.DB;
using Newtonsoft.Json;

namespace NETCORE.Controllers
{

    public class UserController : Controller
    {
        private DbCon condb = new DbCon();
        

        List<Models.ListMenu> listUser = new List<Models.ListMenu>();

       
        public IActionResult Index()
        {

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUser")))
            {
                FetchData();
                return View(listUser);
            }
            else
            {
                return RedirectToAction("Index", "UserAuthen");

            }

                
        }

        


        private void FetchData()
        {
            if(listUser.Count > 0)
            {
                listUser.Clear();
            }

            try
            {
                string sql = "exec [dbo].[WEB_Listmenu] '' ";

                DataSet lSet = new DataSet("office");

                lSet = condb.SqlGet(sql, "office");

                foreach (DataRow row in lSet.Tables[0].Rows)
                {
                    listUser.Add(new Models.ListMenu()
                    {

                        t1 = row["t1"].ToString(),
                        t2 = row["t2"].ToString(),
                        t3 = row["t3"].ToString(),
                        t4 = row["t4"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        



        [HttpGet]
        public JsonResult GetUserAll()
        {
           

            string sql = "exec [dbo].[WEB_Listmenu] '' ";
           
            DataSet lSet = new DataSet("office");

            lSet = condb.SqlGet(sql, "office");

            string json = "";

            if (lSet.Tables[0].Rows.Count > 1)
            {
                json = JsonConvert.SerializeObject(lSet.Tables["office"], Formatting.Indented);
            }

            return Json(json);


        }


    }
}
