using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FiringCodeAuthenticator.Models;

namespace FiringCodeAuthenticator.Controllers
{
    public class AuthenticateCodeController : ApiController
    {
        AuthCode authCode = new AuthCode{ AuthenticCode = "AZ035T29Z1984" };

        [HttpGet]
        public string Authenticate(string code)
        {
            if (string.Equals(authCode.AuthenticCode, code, StringComparison.OrdinalIgnoreCase))
            {
                return "AUTHENTICATED";
            }
            else
            {
                return "DRILL";
            }
        }
    }
}
