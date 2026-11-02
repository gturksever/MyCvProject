using Microsoft.AspNetCore.Mvc;

namespace MyCvProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
