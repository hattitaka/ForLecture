using MyFirstApp.Areas.Admin.Models.Contexts;
using MyFirstApp.Areas.Admin.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.Repository
{
    public class UserRepository
    {
        private MvcBasicContext db = new MvcBasicContext();

        public GetUserDetailsResponse GetUserDetails(GetUserDetailsRequest req)
        {
            var target = db.Users.FirstOrDefault(u => u.Id == req.Id);

            if(target == null)
            {
                var errorMessage = "user is not found";

                return new GetUserDetailsResponse(errorMessage, true);
            }

            return new GetUserDetailsResponse(target);
        }

        public GetUserSummariesResponse GetUserSummaries()
        {
            var users = db.Users;
            var summaries = users
                .Select(u => new UserSummary(u.Id, u.Name, u.MailAddress))
                .ToList();

            if(summaries.Count < 0)
            {
                var errorMessage = "uesr is undefined";

                return new GetUserSummariesResponse(errorMessage, true);
            }

            return new GetUserSummariesResponse(summaries);
        }
    }
}