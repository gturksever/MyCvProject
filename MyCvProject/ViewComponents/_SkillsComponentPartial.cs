using Microsoft.AspNetCore.Mvc;
using MyCvProject.DAL.Context;

namespace MyCvProject.ViewComponents
{
    public class _SkillsComponentPartial : ViewComponent
    {
        MYCvContext CvContext = new MYCvContext();
        public IViewComponentResult Invoke()
        {
            var values = CvContext.Skills.ToList();
            return View(values);
        }
    }
}
