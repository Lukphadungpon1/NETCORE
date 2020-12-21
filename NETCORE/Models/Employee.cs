using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE.Models
{
    public class Employee
    {
        public int empCode { get; set; }
        public string nameTH  { get; set; }
        public string lnameTH  { get; set; }
        public string nameEN { get; set; }
        public string lnameEN { get; set; }
        public string position { get; set; }
        public string department { get; set; }
        public string section { get; set; }
        [Display(Name ="วันเริ่มงาน")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime workDate { get; set; }

        public int Status { get; set; }
        public string email { get; set; }
        public string usernameAD { get; set; }

    }
}
