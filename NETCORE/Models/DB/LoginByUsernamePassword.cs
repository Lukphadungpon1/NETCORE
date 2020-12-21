using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE.Models.DB
{
    public partial class LoginByUsernamePassword
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string Section { get; set; }
        public string Department { get; set; }
    }
}
