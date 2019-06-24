using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.Contexts
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MailAddress { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
    }
}