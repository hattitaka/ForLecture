using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.User
{
    public class GetUserDetailsRequest
    {
        public GetUserDetailsRequest(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}