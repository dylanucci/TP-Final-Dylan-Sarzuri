using System.Runtime.CompilerServices;
using Application.Excepciones;

namespace Backend.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (KeyNotFoundException ex)
            {
                await HandlerExceptionAsync(StatusCodes.Status404NotFound, context, ex.Message);
            }
            catch (IncorrectPasswordException ex)
            {
                _logger.LogCritical(ex.Message);
                await HandlerExceptionAsync(StatusCodes.Status400BadRequest, context, ex.Message);
            }
            catch (EmailAlreadyExistsException ex)
            {
                _logger.LogCritical(ex.Message);
                await HandlerExceptionAsync(StatusCodes.Status400BadRequest, context, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.Message);
                await HandlerExceptionAsync(StatusCodes.Status400BadRequest, context, ex.Message);
            }
        }

        public async Task HandlerExceptionAsync(int status, HttpContext context, string message)
        {
            context.Response.StatusCode = status;
            context.Response.ContentType = "application/json";

            var response = new
            {
                StatusCode = status,
                Error = message,
                URL = context.Request.Path.Value,
                Method = context.Request.Method,
            };
            await context.Response.WriteAsJsonAsync(response);

        }

      
    }
}
