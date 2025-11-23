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
            Console.WriteLine(e);
            throw;
        }
    }
}