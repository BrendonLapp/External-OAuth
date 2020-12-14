using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Namespaces added
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BAIS3110_OAuth_Brendon_Lapp.Services
{
    /// <summary>
    /// The authentication controller that handles all authentication requests
    /// </summary>
    [Route("[controller]/[action]")]
    public class AuthController : Controller
    {
        /// <summary>
        /// Performs a login attempt
        /// </summary>
        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }
    }
}
