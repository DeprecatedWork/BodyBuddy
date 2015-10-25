using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using BodyBuddy.Models;

namespace BodyBuddy
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
          

            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "1507333236231737",
                appSecret: "3098de841bfd087871a86382378978d0");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
