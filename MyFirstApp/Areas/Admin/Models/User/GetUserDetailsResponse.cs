using MyFirstApp.Areas.Admin.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.User
{
    public class GetUserDetailsResponse: ResponseBase
    {
        public GetUserDetailsResponse(Contexts.User source)
        {
            Id = source.Id;
            Name = source.Name;
            LoginId = source.LoginId;
            MailAddress = source.MailAddress;
            Password = source.Password;
        }

        public GetUserDetailsResponse(string errorMessage, bool hasError) 
            : base(errorMessage, hasError) { }

        public string Id { get; }

        public string Name { get; }

        public string MailAddress { get; }

        public string LoginId { get; }

        public string Password { get; }
    }
}