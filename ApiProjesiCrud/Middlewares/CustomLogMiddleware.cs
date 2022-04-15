using ApiProjesiCrud.Services;
using Microsoft.Extensions.Logging;

namespace ApiProjesiCrud.Middlewares
{
    public class CustomLogMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogService _loggerService;

        public CustomLogMiddleware(RequestDelegate next, ILogService loggerService)
        {
            _next = next;
            _loggerService = loggerService;
        }

        public async Task Invoke(HttpContext context)
        {
            
            string message = $"[Request]  HTTP - {context.Request.Method} - {context.Request.Path}";
            _loggerService.Log(message);
            await _next(context);

            message =
                $"[Response] HTTP - {context.Request.Method} - {context.Request.Path} - {context.Response.StatusCode}";
            _loggerService.Log(message);
        }
    }
}
