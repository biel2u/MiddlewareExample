using Owin;

namespace MiddlewareExample.FullFramework
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCultureMiddleware();
        }
    }
}