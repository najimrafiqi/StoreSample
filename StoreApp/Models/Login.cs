using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApp.Models
{
    public class Login
    {
        public int UserId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
    }
}