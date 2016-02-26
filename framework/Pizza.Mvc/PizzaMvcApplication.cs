﻿using System;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;
using Pizza.Contracts.Security;
using Pizza.Framework.Security;
using Pizza.Framework.Utils.ValueInjection;
using Pizza.Mvc.Security;

namespace Pizza.Mvc
{
    public class DefaultPizzaMvcApplication : PizzaMvcApplicationBase<DefaultPizzaPrincipal, PizzaPrincipalSerializeModel>
    {
    }

    public abstract class PizzaMvcApplicationBase<TPizzaPrincipal, TPrincipalSerializeModel> : HttpApplication 
        where TPizzaPrincipal : DefaultPizzaPrincipal
    {
        protected void Application_PostAuthenticateRequest(object sender, EventArgs e)
        {
            HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];

            if (authCookie != null)
            {
                var authTicket = FormsAuthentication.Decrypt(authCookie.Value);

                var user = this.GetPrincipal(authTicket);
                if (user == null)
                {
                    return;
                }

                HttpContext.Current.User = user;
            }
        }

        protected virtual TPizzaPrincipal GetPrincipal(FormsAuthenticationTicket ticket)
        {
            var serializeModel = new JavaScriptSerializer().Deserialize<TPrincipalSerializeModel>(ticket.UserData);

            if (serializeModel == null)
            {
                return null;
            }

            var newUser = (TPizzaPrincipal)Activator.CreateInstance(typeof(TPizzaPrincipal), ticket.Name);
            newUser.InjectFrom(serializeModel);

            return newUser;
        }
    }
}