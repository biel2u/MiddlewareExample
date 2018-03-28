using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MiddlewareExample.Core
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var culture = CultureInfo.CurrentCulture.ToString();
            httpContext.Response.Headers.Add("Culture", culture);

            return _next(httpContext);
        }
    }

    public static class CultureMiddlewareExtensions
    {
        public static IApplicationBuilder UseCultureMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureMiddleware>();
        }
    }
}