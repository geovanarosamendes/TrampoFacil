using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;
using TrampoFacil.Exceptions;

namespace TrampoFacil.API.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context); 
            }
            catch (AppExceptions ex) 
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = ex.StatusCode;

                var response = new { erro = ex.Message };

                await context.Response.WriteAsync(JsonSerializer.Serialize(response));
            }
            catch (Exception)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var response = new { erro = "Erro interno do servidor." };

                await context.Response.WriteAsync(JsonSerializer.Serialize(response));
            }
        }
    }
}
