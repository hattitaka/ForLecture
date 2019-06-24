using MyFirstApp.Areas.Admin.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.Repository
{
    public class ContentRepository
    {
        public MvcBasicContext db = new MvcBasicContext();
    }
}