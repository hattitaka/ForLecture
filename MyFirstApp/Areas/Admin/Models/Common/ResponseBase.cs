using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Areas.Admin.Models.Common
{
    public class ResponseBase
    {
        public ResponseBase(string errorMessage = null, bool hasError = false )
        {
            ErrorMessage = errorMessage;
            HasError = hasError;
        }

        public string ErrorMessage { get; }

        public bool HasError { get; }
    }
}