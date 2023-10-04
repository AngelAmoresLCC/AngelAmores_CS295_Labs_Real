using Microsoft.AspNetCore.Mvc;

namespace CommunityOfMars.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
