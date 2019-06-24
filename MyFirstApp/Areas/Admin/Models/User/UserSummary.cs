using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.User
{
    public class UserSummary
    {
        public UserSummary(string id, string name, string mailAddress)
        {
            Id = id;
            Name = name;
            MailAddress = mailAddress;
        }

        public string Id { get; }

        public string Name { get; }

        public string MailAddress { get; }
    }
}