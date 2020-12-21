using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Hosting;
using System.Text;
using System.IO;
using Microsoft.AspNetCore.Http;
namespace NETCORE.Controllers
{
    public class Excel_Im_ExController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Download()

        {

            string Files = "wwwroot/UploadExcel/CoreProgramm_ExcelImport.xlsx";

            byte[] fileBytes = System.IO.File.ReadAllBytes(Files);

            System.IO.File.WriteAllBytes(Files, fileBytes);

            MemoryStream ms = new MemoryStream(fileBytes);

            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, "employee.xlsx");

        }
}
}
