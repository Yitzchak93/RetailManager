using Microsoft.AspNet.Identity;
using RMDataManager.Library.DataAccess;
using RMDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;

namespace RMDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public UserModel GetUserById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId).First();
        }
    }
}
