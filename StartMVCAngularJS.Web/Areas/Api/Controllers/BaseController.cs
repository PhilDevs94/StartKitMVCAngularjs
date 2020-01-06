using Microsoft.AspNet.Identity;
using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StartMVCAngularJS.Web.Areas.Api.Controllers
{
    public class BaseController : ODataController
    {
        // GET: Api/Base
        private readonly string CURRENT_USER_ID;
        private readonly string CURRENT_USER_NAME;

        public BaseController()
        {
            CURRENT_USER_ID = HttpContext.Current.User.Identity.GetUserId();
            CURRENT_USER_NAME = HttpContext.Current.User.Identity.GetUserName();
        }

        protected string GetCurrentUserId()
        {
            return this.CURRENT_USER_ID;
        }

        protected string GetCurrentUserName()
        {
            return this.CURRENT_USER_NAME;
        }
    }
}