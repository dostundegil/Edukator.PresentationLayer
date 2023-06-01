using Edukator.DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _StatisticPartial:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Categories.Count();
            ViewBag.v2 = context.Courses.Count();
            ViewBag.v3 = 684;
            return View();
        }
    }
}
