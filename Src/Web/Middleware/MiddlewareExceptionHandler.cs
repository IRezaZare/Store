using System.Net;
using System.Text.Json;
using Domain.Exceptions;

namespace Web.Middleware;

public class MiddlewareExceptionHandler
{
    private readonly IWebHostEnvironment _env;
    private readonly ILoggerFactory _logger;
    private readonly RequestDelegate _next;

    public MiddlewareExceptionHandler(IWebHostEnvironment env, ILoggerFactory logger, RequestDelegate next)
    {
        _env = env;
        _logger = logger;
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception e)
        {
            var options = HandleServerError(context);
            var result = JsonSerializer.Serialize(new ApiToReturn(500, e.Message), options);
            result = HandleResult(context, e, result, options);
            await context.Response.WriteAsync(result);
        }
    }

    private static JsonSerializerOptions HandleServerError(HttpContext context)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        var option = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        return option;
    }

    private string HandleResult(HttpContext context, Exception exception, string result,
        JsonSerializerOptions options)
    {
        switch (exception)
        {
            case NotFoundEntityException notFoundException:
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                result = JsonSerializer.Serialize(new ApiToReturn(404, notFoundException.Messages,
                    notFoundException.Message, exception.Message),options);
                break;

            case BadRequestEntityException badRequestException:
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                result = JsonSerializer.Serialize(new ApiToReturn(400, badRequestException.Messages,
                    badRequestException.Message, exception.Message),options);
                break;
            case ValidationEntityException validationEntityException:
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                result = JsonSerializer.Serialize(new ApiToReturn(400, validationEntityException.Messages,
                    validationEntityException.Message, exception.Message),options);
                break;
        }

        return result;
    }
}