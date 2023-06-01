using Edukator.DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardStatisticPartial:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.totalCourseCount = context.Courses.Count();
            ViewBag.totalCourseCategory=context.Categories.Count();
            ViewBag.totalMember=context.Users.Count();
            ViewBag.messageBoxCount=context.Messages.Count();
            return View();
        }
    }
}
