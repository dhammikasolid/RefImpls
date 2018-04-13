using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using IdentityModel.Client;
using Microsoft.Owin.Security;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;

[assembly: OwinStartup(typeof(DotNetMvcClient.Startup))]

namespace DotNetMvcClient
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                ClientId = "mvc.owin.hybrid",
                Authority = "http://localhost:5000",
                RedirectUri = "https://localhost:5004/",
                PostLogoutRedirectUri = "https://localhost:5004/",
                ResponseType = "code id_token",
                Scope = "openid profile read write offline_access",

                TokenValidationParameters = new TokenValidationParameters
                {
                    NameClaimType = "name",
                    RoleClaimType = "role"
                },

                SignInAsAuthenticationType = "Cookies",

                //Notifications = new OpenIdConnectAuthenticationNotifications
                //{
                //    AuthorizationCodeReceived = async n =>
                //    {
                //        // use the code to get the access and refresh token
                //        var tokenClient = new TokenClient(
                //            "https://localhost:5000/core/connect/token",
                //            "mvc.owin.hybrid",
                //            "secret");

                //        var tokenResponse = await tokenClient.RequestAuthorizationCodeAsync(
                //            n.Code, n.RedirectUri);

                //        if (tokenResponse.IsError)
                //        {
                //            throw new Exception(tokenResponse.Error);
                //        }

                //        // use the access token to retrieve claims from userinfo
                //        var userInfoClient = new UserInfoClient(
                //        new Uri("https://localhost:5000/core/connect/token"),
                //        tokenResponse.AccessToken);

                //        var userInfoResponse = await userInfoClient.GetAsync();

                //        // create new identity
                //        var id = new ClaimsIdentity(n.AuthenticationTicket.Identity.AuthenticationType);
                //        id.AddClaims(userInfoResponse.GetClaimsIdentity().Claims);

                //        id.AddClaim(new Claim("access_token", tokenResponse.AccessToken));
                //        id.AddClaim(new Claim("expires_at", DateTime.Now.AddSeconds(tokenResponse.ExpiresIn).ToLocalTime().ToString()));
                //        id.AddClaim(new Claim("refresh_token", tokenResponse.RefreshToken));
                //        id.AddClaim(new Claim("id_token", n.ProtocolMessage.IdToken));
                //        id.AddClaim(new Claim("sid", n.AuthenticationTicket.Identity.FindFirst("sid").Value));

                //        n.AuthenticationTicket = new AuthenticationTicket(
                //            new ClaimsIdentity(id.Claims, n.AuthenticationTicket.Identity.AuthenticationType, "name", "role"),
                //            n.AuthenticationTicket.Properties);
                //    },

                //    RedirectToIdentityProvider = n =>
                //    {
                //        // if signing out, add the id_token_hint
                //        if (n.ProtocolMessage.RequestType == OpenIdConnectRequestType.LogoutRequest)
                //        {
                //            var idTokenHint = n.OwinContext.Authentication.User.FindFirst("id_token");

                //            if (idTokenHint != null)
                //            {
                //                n.ProtocolMessage.IdTokenHint = idTokenHint.Value;
                //            }

                //        }

                //        return Task.FromResult(0);
                //    }
                //}
            });
        }
    }
}
