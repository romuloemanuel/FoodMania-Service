using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
using ApplicationException = FoodMania.Application.Core.Exceptions.ApplicationException;

namespace FoodMania.Infra.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            HttpStatusCode code = HttpStatusCode.InternalServerError;
            switch (exception)
            {
                case ApplicationException:
                    code = HttpStatusCode.BadRequest;
                    break;
                default:
                    break;
            }
            var result = JsonConvert.SerializeObject(new { error = exception.Message });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }

    }
}
