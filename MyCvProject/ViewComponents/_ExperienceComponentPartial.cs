using Microsoft.AspNetCore.Mvc;
using MyCvProject.DAL.Context;

namespace MyCvProject.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MYCvContext CvContext = new MYCvContext();
        public IViewComponentResult Invoke()
        {
            var values = CvContext.Experiences.ToList();
            return View(values);
        }
    }
}
