using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WindowsAuthentication.Controllers
{/// <summary>
/// This is user defined controller having different actions like Admin,Volunteer,User with different Authorizations.
/// </summary>
    public class AuthenticationController : Controller
    {/// <summary>
    /// This action is only accessed by Admin
    /// </summary>
    /// <returns></returns>
        [Authorize(Users = @"Administrator")]
        // GET: Ahuthentication
        public ActionResult Admin()
        {
            return View();
        }/// <summary>
        /// This action is only accessed by Specified User
        /// </summary>
        /// <returns></returns>
        [Authorize(Users = @"PRINCETON\Varundhar_Gandham")]
        public ActionResult Volunteer ()
        {
            return View();
        }/// <summary>
        /// This action is accessed by specified user
        /// </summary>
        /// <returns></returns>
        [Authorize(Users = @"PRINCETON\Santosh_Pisini")]
      
        public ActionResult Owner()
        {
            return View();
        }
    }
}