using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace TarefasApp.Middleware
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;
        
        List<string> DoNotRedirect = new List<string> {"/usuarios/login", "/usuarios/create", "/home/sobre"};

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (DoNotRedirect.Contains(httpContext.Request.Path.ToString().ToLower()))
            {
                await _next(httpContext);
                return;
            }
            if (string.IsNullOrEmpty(httpContext.Session.GetString("SessionStatus")))
            {
                httpContext.Response.Redirect("/usuarios/login");
            }
            await _next(httpContext);
        }
    }
}