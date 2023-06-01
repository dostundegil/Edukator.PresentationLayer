using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.DefaultCourses
{
    public class _CoursesPartial:ViewComponent
    {
        private readonly ICourseService _courseService;

        public _CoursesPartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetCourseswithCategories();
            return View(values);
        }
    }
}
