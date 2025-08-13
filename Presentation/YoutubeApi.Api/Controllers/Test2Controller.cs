using Microsoft.AspNetCore.Mvc;

namespace YoutubeApi.Api.Controllers
{
    public class Test2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
