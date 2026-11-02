using Microsoft.AspNetCore.Mvc;

namespace MyCvProject.ViewComponents
{
    public class _NawbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
