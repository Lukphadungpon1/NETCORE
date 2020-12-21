using System;
using System.Collections.Generic;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class WebItpassword
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Detail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Area { get; set; }
        public string Type { get; set; }
        public string IpAddress { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
        public long? Status { get; set; }
    }
}
