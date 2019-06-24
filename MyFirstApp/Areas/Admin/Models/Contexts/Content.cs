using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.Contexts
{
    public class Content
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Profile { get; set; }
    }
}