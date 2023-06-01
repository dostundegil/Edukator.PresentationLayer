using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class DefaultCourses : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
