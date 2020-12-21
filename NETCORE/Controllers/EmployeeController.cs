using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCORE.Models;
using System.Data;
using NETCORE.DBContext;
using Newtonsoft.Json;
using NETCORE.Models.DB;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NETCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private DbCon condb = new DbCon();
        KPIContext db = new KPIContext();


        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult <IEnumerable<Models.Employee>> Get()
        {
            List<Models.Employee> emp = new List<Models.Employee>();

            try
            {
                string sql = "select * from WEB_EmployeeList where  Status = 1 ";

                DataSet lSet = new DataSet("office");

                lSet = condb.SqlGet(sql, "office");

                foreach (DataRow row in lSet.Tables[0].Rows)
                {
                    emp.Add(new Models.Employee()
                    {
                        empCode = Convert.ToInt32(row["empCode"].ToString()),
                        nameTH = row["nameTH"].ToString(),
                        lnameTH = row["lnameTH"].ToString(),
                        nameEN = row["nameEN"].ToString(),
                        lnameEN = row["lnameEN"].ToString(),
                        position = row["position"].ToString(),
                        department = row["department"].ToString(),
                        section = row["section"].ToString(),
                        workDate = Convert.ToDateTime(row["workDate"].ToString()),
                        Status = Convert.ToInt32(row["Status"].ToString()),

                    });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(emp);
        }

        [HttpGet("Getdepartment/{name}")]
        public ActionResult<Department> Getdepartment(string name)
        {
            List<Department> dept = new List<Department>();

            try
            {
                string sql = "select department from WEB_EmployeeList where  Status = 1 group by department ";

                DataSet lSet = new DataSet("office");

                lSet = condb.SqlGet(sql, "office");

                foreach (DataRow row in lSet.Tables[0].Rows)
                {
                    dept.Add(new Department()
                    {
                        department = row["department"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(dept);
        }

        [HttpGet("Login/{id}")]
        public async Task<List<LoginViewModel>> GetLogon()
        {
            var result = await db.GetLoginByUsernamePassword.FromSqlRaw("exec [dbo].[WEB_UserLogin] 'Mr.Theerayuth','123456'").ToListAsync();
            List<LoginViewModel> lst = result.Select(s => new LoginViewModel
            {
                Username = s.Username,
                Password = s.Password

            }).ToList();

            return lst;

        }

        [HttpGet("ListMenu/{id}")]
        public async Task<List<ListViewModel>> GetListMenu1()
        {
            var result = await db.GetListMenu1.FromSqlRaw("exec [dbo].[WEB_Listmenu] ''").ToListAsync();
            List<ListViewModel> lst = result.Select(s => new ListViewModel
            {
                t1 = s.t1,
                t2 = s.t2,
                t3 = s.t3,
                t4 = s.t4

            }).ToList();

            return lst;

        }


        // GET api/<EmployeeController>/5
        [HttpGet("/{id}")]
        public ActionResult<Models.Employee> Get(int id)
        {
            List<Models.Employee> emp = new List<Models.Employee>();
            try
            {
                string sql = "select * from WEB_EmployeeList where  Status = 1 and empCode = '" + id + "' ";

                DataSet lSet = new DataSet("office");

                lSet = condb.SqlGet(sql, "office");

                foreach (DataRow row in lSet.Tables[0].Rows)
                {
                    emp.Add(new Models.Employee()
                    {
                        empCode = Convert.ToInt32(row["empCode"].ToString()),
                        nameTH = row["nameTH"].ToString(),
                        lnameTH = row["lnameTH"].ToString(),
                        nameEN = row["nameEN"].ToString(),
                        lnameEN = row["lnameEN"].ToString(),
                        position = row["position"].ToString(),
                        department = row["department"].ToString(),
                        section = row["section"].ToString(),
                        workDate = Convert.ToDateTime(row["workDate"].ToString()),
                        Status = Convert.ToInt32(row["Status"].ToString()),

                    });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(emp);

        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult Post([FromBody] List<Models.Employee> emp)
        {

            string sql = "INSERT INTO [dbo].[WEB_EmployeeList] " +
"([depCode] ,[empCode] ,[nameTH] ,[lnameTH] ,[nameEN] ,[lnameEN] ,[position] ,[department] ,[section] ,[workDate] ,[Status] ,[email] ,[usernameAD]) " +
"VALUES ";

            foreach (Models.Employee row in emp)
            {
                
                sql += "('0001','"+ row.empCode+ "','nameTH','lnameTH','nameEN','lnameEN','position','department','section','2020-12-01','1','test@gmail.com','userAD'),";
            }

            // if (condb.SqlExecute(sql.Substring(0,sql.Length-1)) == 1)
            //{
            //    return "OK";
            //}
            //else
            //{
            //    return "Fail to Add";
            //}
            return Ok("OK");

        }



        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, List<Models.Employee> emp)
        {
            return Ok("OK");




        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
