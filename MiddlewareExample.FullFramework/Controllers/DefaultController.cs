using System.Web.Http;

namespace MiddlewareExample.FullFramework.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "It's default message. In headers you can find your culture.";
        }
    }
}
