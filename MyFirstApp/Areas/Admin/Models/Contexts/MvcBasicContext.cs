using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.Contexts
{
    public class MvcBasicContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Content> Cotents { get; set; }
    }    
}