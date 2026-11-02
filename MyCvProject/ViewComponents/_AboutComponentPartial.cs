using Microsoft.AspNetCore.Mvc;
using MyCvProject.DAL.Context;

namespace MyCvProject.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MYCvContext CvContext = new MYCvContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle= CvContext.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=CvContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=CvContext.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
