using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.Web.Http.Controllers;
using System.Diagnostics.Contracts;
using System.Web.Http;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using monaguaRules.Entities;
using monaguaRules.Mappers;

namespace API.Clases
{
    public class TokenValidationHandler : DelegatingHandler
    {

        private static bool TryRetrieveToken(HttpRequestMessage request, out string token)
        {
            token = null;
            IEnumerable<string> authzHeaders;
            if (!request.Headers.TryGetValues("Authorization", out authzHeaders) || authzHeaders.Count() > 1)
            {
                return false;
            }
            var bearerToken = authzHeaders.ElementAt(0);
            token = bearerToken.StartsWith("Bearer ") ? bearerToken.Substring(7) : bearerToken;
            return true;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpStatusCode statusCode;
            string token;

            // determine whether a jwt exists or not

            if (!TryRetrieveToken(request, out token))
            {

            }
            if (request.Method.ToString() == "OPTIONS")
            {
                statusCode = HttpStatusCode.OK;
            }

            try
            {

                if (ValidaToken(request))
                {
                    statusCode = HttpStatusCode.OK;
                    return base.SendAsync(request, cancellationToken);
                }
                else
                {
                    statusCode = HttpStatusCode.Unauthorized;
                    return base.SendAsync(request, cancellationToken);
                }
            }
            catch (SecurityTokenValidationException)
            {
                statusCode = HttpStatusCode.Unauthorized;
            }
            catch (Exception)
            {
                statusCode = HttpStatusCode.InternalServerError;
            }



            return Task<HttpResponseMessage>.Factory.StartNew(() => new HttpResponseMessage(statusCode) { });
        }
        public static bool LifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken securityToken, TokenValidationParameters validationParameters)
        {
            if (expires != null)
            {
                if (DateTime.UtcNow < expires) return true;
            }
            return false;

        }

        public static bool ValidaToken(HttpRequestMessage request)
        {
            string token;
            bool ret = true;
            try
            {
                if (!TryRetrieveToken(request, out token))
                {
                    if (request.Method.ToString() != "OPTIONS")
                    {
                        ret = false;
                    }
                }
                else
                {
                    var secretKey = "s3rv4t_h0m3_w3b!";
                    var audienceToken = ConfigurationManager.AppSettings["urlFront"];
                    var issuerToken = ConfigurationManager.AppSettings["urlFront"];


                    var securityKey = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(secretKey));

                    SecurityToken securityToken;
                    var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                    TokenValidationParameters validationParameters = new TokenValidationParameters()
                    {
                        ValidAudience = audienceToken,
                        ValidIssuer = issuerToken,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        LifetimeValidator = TokenValidationHandler.LifetimeValidator,
                        IssuerSigningKey = securityKey
                    };


                    // Extract and assign Current Principal and user
                    System.Security.Claims.ClaimsPrincipal iden = tokenHandler.ValidateToken(token, validationParameters, out securityToken);
                    var identity = iden.Identity;
                    if (request.RequestUri.ToString().Contains("Admin/"))
                    {
                        /*Usuarios  u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                        if (u != null)
                        {
                            if (u.ClientesEntity != null || u.PrestadoresEntity!=null)
                            {
                                ret = false;
                            }
                        }
                        else
                        {
                            ret = false;
                        }*/

                    }


                    // Extract and assign Current Principal and user
                    Thread.CurrentPrincipal = tokenHandler.ValidateToken(token, validationParameters, out securityToken);
                    HttpContext.Current.User = tokenHandler.ValidateToken(token, validationParameters, out securityToken);

                    
                }

                return ret;
            }
            catch (SecurityTokenValidationException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}