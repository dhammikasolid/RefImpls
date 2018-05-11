/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using IdentityServer3.Core;
using IdentityServer3.Core.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityServer3.Host.Config
{
    public class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                /////////////////////////////////////////////////////////////
                // JavaScript Implicit Client - OAuth only
                /////////////////////////////////////////////////////////////
                new Client
                {
                    ClientName = "JavaScript Implicit Client - Simple",
                    ClientId = "js.simple",
                    Flow = Flows.Implicit,

                    AllowedScopes = new List<string>
                    {
                        "read",
                        "write"
                    },

                    ClientUri = "https://identityserver.io",

                    RequireConsent = true,
                    AllowRememberConsent = true,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:37045/index.html",
                    },
                },

                /////////////////////////////////////////////////////////////
                // JavaScript Implicit Client - Manual
                /////////////////////////////////////////////////////////////
                new Client
                {
                    ClientName = "JavaScript Implicit Client - Manual",
                    ClientId = "js.manual",
                    Flow = Flows.Implicit,

                    AllowedScopes = new List<string>
                    {
                        "openid",
                        "email",
                        "read",
                        "write"
                    },

                    ClientUri = "https://identityserver.io",

                    RequireConsent = true,
                    AllowRememberConsent = true,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:37046/index.html",
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:37046"
                    }
                },

                /////////////////////////////////////////////////////////////
                // JavaScript Implicit Client - TokenManager
                /////////////////////////////////////////////////////////////
                new Client
                {
                    ClientName = "JavaScript Implicit Client - UserManager",
                    ClientId = "js.usermanager",
                    Flow = Flows.Implicit,

                    AllowedScopes = new List<string>
                    {
                        Constants.StandardScopes.OpenId,
                        Constants.StandardScopes.Profile,
                        Constants.StandardScopes.Email,
                        Constants.StandardScopes.Roles,
                        "read",
                        "write"
                    },

                    ClientUri = "https://identityserver.io",

                    RequireConsent = true,
                    AllowRememberConsent = true,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:21575/index.html",
                        "http://localhost:21575/silent_renew.html",
                        "http://localhost:21575/callback.html",
                        "http://localhost:21575/frame.html",
                        "http://localhost:21575/popup.html",
                    },

                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:21575/index.html",
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:21575",
                    },

                    AccessTokenLifetime = 3600,
                    AccessTokenType = AccessTokenType.Jwt
                },

                /////////////////////////////////////////////////////////////
                // MVC CodeFlowClient Manual
                /////////////////////////////////////////////////////////////
                new Client
                {
                    ClientName = "Code Flow Client Demo",
                    ClientId = "codeclient",
                    Flow = Flows.AuthorizationCode,

                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },

                    RequireConsent = true,
                    AllowRememberConsent = true,

                    ClientUri = "https://identityserver.io",

                    RedirectUris = new List<string>
                    {
                        "https://localhost:44312/callback",
                    },

                    AllowedScopes = new List<string>
                    {
                        Constants.StandardScopes.OpenId,
                        Constants.StandardScopes.Profile,
                        Constants.StandardScopes.Email,
                        Constants.StandardScopes.Roles,
                        Constants.StandardScopes.OfflineAccess,
                        "read",
                        "write"
                    },

                    AccessTokenType = AccessTokenType.Reference,
                },

                /////////////////////////////////////////////////////////////
                // MVC No Library Client
                /////////////////////////////////////////////////////////////
                new Client
                {
                    ClientName = "OpenID Connect without Client Library Sample",
                    ClientId = "nolib.client",
                    Flow = Flows.Implicit,

                    AllowedScopes = new List<string>
                    {
                        Constants.StandardScopes.OpenId,
                        Constants.StandardScopes.Profile,
                        Constants.StandardScopes.Email,
                        Constants.StandardScopes.Roles,
                        Constants.StandardScopes.Address,
                        "read",
                        "write"
                    },

                    ClientUri = "https://identityserver.io",

                    RequireConsent = true,
                    AllowRememberConsent = true,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:11716/account/signInCallback",
                    },
                },

                /////////////////////////////////////////////////////////////
                // MVC OWIN Hybrid Client
                /////////////////////////////////////////////////////////////
                new Client
                {
                    ClientName = "MVC OWIN Hybrid Client",
                    ClientId = "mvc.owin.hybrid",
                    Flow = Flows.Hybrid,
                    AllowAccessTokensViaBrowser = false,

                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },

                    AllowedScopes = new List<string>
                    {
                        Constants.StandardScopes.OpenId,
                        Constants.StandardScopes.Profile,
                        Constants.StandardScopes.Email,
                        Constants.StandardScopes.Roles,
                        Constants.StandardScopes.OfflineAccess,
                        "read",
                        "write"
                    },

                    ClientUri = "https://identityserver.io",

                    RequireConsent = false,
                    AccessTokenType = AccessTokenType.Reference,

                    RedirectUris = new List<string>
                    {
                        "https://localhost:44300/"
                    },

                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:44300/"
                    },

                    LogoutUri = "https://localhost:44300/Home/OidcSignOut",
                    LogoutSessionRequired = true
                },

                
                /////////////////////////////////////////////////////////////
                // MVC OWIN Implicit Client
                /////////////////////////////////////////////////////////////
                new Client
                {
                    ClientName = "MVC OWIN Implicit Client",
                    ClientId = "mvc.owin.implicit",
                    Flow = Flows.Implicit,
                    AllowAccessTokensViaBrowser = false,

                    AllowedScopes = new List<string>
                    {
                        Constants.StandardScopes.OpenId,
                        Constants.StandardScopes.Profile,
                        Constants.StandardScopes.Email,
                        Constants.StandardScopes.Roles,
                        Constants.StandardScopes.Address,
                    },

                    ClientUri = "https://identityserver.io",

                    RequireConsent = true,
                    AllowRememberConsent = true,

                    RedirectUris = new List<string>
                    {
                        "https://localhost:44301/"
                    },

                    LogoutUri = "https://localhost:44301/Home/SignoutCleanup",
                    LogoutSessionRequired = true,
                },
            };
        }
    }
}