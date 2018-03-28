using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace MiddlewareExample.FullFramework
{
    public class CultureMiddleware : OwinMiddleware
    {
        public CultureMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override Task Invoke(IOwinContext context)
        {
            var culture = CultureInfo.CurrentCulture.ToString();
            context.Response.Headers["Culture"] = culture;

            return Next.Invoke(context);
        }
    }

    public static class CultureMiddlewareExtensions
    {
        public static IAppBuilder UseCultureMiddleware(this IAppBuilder builder)
        {
            return builder.Use(typeof(CultureMiddleware));
        }
    }
}