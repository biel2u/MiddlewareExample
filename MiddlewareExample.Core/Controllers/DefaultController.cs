using Microsoft.AspNetCore.Mvc;

namespace MiddlewareExample.Core.Controllers
{
    [Route("api/[controller]")]
    public class DefaultController : Controller
    {
        public string Get()
        {
            return "It's default message. In headers you can find your culture.";
        }
    }
}