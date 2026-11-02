using Microsoft.AspNetCore.Mvc;

namespace MyCvProject.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
