using Microsoft.AspNetCore.Mvc;
using MyCvProject.DAL.Context;

namespace MyCvProject.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {

        MYCvContext CvContext = new MYCvContext();
        public IViewComponentResult Invoke()
        {
            var values = CvContext.Features.ToList();
            return View(values);
        }
    }
}
