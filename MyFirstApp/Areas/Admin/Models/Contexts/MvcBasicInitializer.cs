using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.Contexts
{
    public class MvcBasicInitializer: DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var users = new List<User>();

            for (int i = 0; i < 10; i++)
            {
                var user = new User()
                {
                    Id = i.ToString(),
                    Name = "User" + i,
                    MailAddress = "user" + i + "@gmail.com",
                    LoginId = "login" + i,
                    Password = "password" + i,
                };
                context.Users.Add(user);
            }
            context.SaveChanges();
        }
    }
}