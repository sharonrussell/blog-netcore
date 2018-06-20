using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "This is a dummy blog entry";
        }
    }
}