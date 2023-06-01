using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Edukator.PresentationLayer.Controllers
{
	public class CourseController : Controller
	{
		private readonly ICourseService _courseService;
		private readonly ICategoryService _categoryService;
        public CourseController(ICourseService courseService, ICategoryService categoryService)
        {
            _courseService = courseService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
		{
			var values=_courseService.TGetCoursesWithCategory();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddCourse()
		{
			List<SelectListItem> values = (from x in _categoryService.TGetList()
										   select new SelectListItem
										   {
											   Text = x.CategoryName,
											   Value = x.CategoryID.ToString()
										   }).ToList();
			ViewBag.v = values;
			return View();
		}

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
			_courseService.TInsert(course);
			return RedirectToAction("Index");
        }

        public IActionResult DeleteCourse(int id)
        {
			var values = _courseService.TGetById(id);
            _courseService.TInsert(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCourse(int id)
        {
            List<SelectListItem> value = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = value;

            var values = _courseService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCourse(Course course)
        {
            _courseService.TUpdate(course);
            return RedirectToAction("Index");
        }
    }
}
