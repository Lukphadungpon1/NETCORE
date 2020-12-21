using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class Employee
    {
        public string Empid { get; set; }
        public string Empname { get; set; }
        public string Empdepart { get; set; }
        public string Position { get; set; }
        public string Groupid { get; set; }
        public string Companyid { get; set; }
        public string Password { get; set; }
        public string Usertype { get; set; }
        public string Stat { get; set; }
    }
}
