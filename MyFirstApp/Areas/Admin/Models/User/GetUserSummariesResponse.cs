using MyFirstApp.Areas.Admin.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.User
{
    public class GetUserSummariesResponse: ResponseBase
    {
        public GetUserSummariesResponse(List<UserSummary> summaries)
        {
            Summaries = summaries;
        }

        public GetUserSummariesResponse(string errorMessage, bool hasError)
            : base(errorMessage, hasError) { }

        public List<UserSummary> Summaries { get; }
    }
}