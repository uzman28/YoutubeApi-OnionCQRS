using Microsoft.AspNetCore.Mvc;

namespace YoutubeApi.Api.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
