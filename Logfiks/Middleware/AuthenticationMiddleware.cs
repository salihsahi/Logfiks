using LogFiks.Business.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logfiks.Middleware
{
    public class AuthenticationMiddleware
    {

        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IApiKullanicilariService _ApiKullanicilariService)
        {
            string authHeader = context.Request.Headers["Authorization"];
            if (authHeader != null && authHeader.StartsWith("Basic"))
            {
                string encodedUsernamePassword = authHeader.Substring("Basic ".Length).Trim();
                Encoding encoding = Encoding.GetEncoding("iso-8859-1");
                string usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));

                int seperatorIndex = usernamePassword.IndexOf(':');

                var username = usernamePassword.Substring(0, seperatorIndex);
                var password = usernamePassword.Substring(seperatorIndex + 1);

                if (_ApiKullanicilariService.Login(username, password))
                {
                    await _next.Invoke(context);
                }
                else
                {
                    context.Response.StatusCode = 401;
                    return;
                }
            }
            else
            {
                context.Response.StatusCode = 401;
                return;
            }
        }
    }
}
