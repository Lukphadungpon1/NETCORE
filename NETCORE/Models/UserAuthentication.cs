using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE.Models
{
    public class UserAuthentication
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Position { get; set; }
        public string Section { get; set; }
        public string Department { get; set; }
    }
}
