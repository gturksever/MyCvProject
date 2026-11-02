using Microsoft.AspNetCore.Mvc;

namespace MyCvProject.ViewComponents
{
    public class _HeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
