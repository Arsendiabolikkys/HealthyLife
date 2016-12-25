using HealthyLife.Business.Models;
using HealthyLife.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace HealthyLife.Web.User
{
    public class WebUserContext
    {
        private bool IsPrincipalAvailable()
        {
            if (HttpContext.Current == null)
                return false;

            var principal = HttpContext.Current.User;
            if (principal == null)
                return false;

            if (principal.Identity == null)
                return false;

            return true;
        }

        private IPrincipal WebUser
        {
            get
            {
                if (!IsPrincipalAvailable())
                    return null;

                return HttpContext.Current.User;
            }
        }

        public bool IsLoggedIn
        {
            get
            {
                return IsPrincipalAvailable() && WebUser.Identity.IsAuthenticated;
            }
        }

        public bool IsAdmin
        {
            get
            {
                if (Account == null)
                    return false;
                return IsPrincipalAvailable() && Account.RoleId == SiteContext.Role.GetByName(Constants.Role.Admin).Id;
            }
        }

        public bool IsDoctor
        {
            get
            {
                if (Account == null)
                    return false;
                return IsPrincipalAvailable() && Account.RoleId == SiteContext.Role.GetByName(Constants.Role.Doctor).Id;
            }
        }

        public Account Account
        {
            get
            {
                if (!IsLoggedIn)
                    return null;

                return DependencyResolver.Current.GetService<IAccountManager>().GetByEmail(WebUser.Identity.Name);
            }
        }
    }
}