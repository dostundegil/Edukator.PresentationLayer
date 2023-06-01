using Edukator.DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.Controllers
{
	public class StatisticController : Controller
	{
		public IActionResult Index()
		{
			Context context = new Context();
			ViewBag.totalCategory = context.Categories.Count();
            ViewBag.totalCourse = context.Courses.Count();
            ViewBag.totalCoursePrice = context.Courses.Sum(x=>x.Price);
            ViewBag.CourseAveragePrice = context.Courses.Average(x => x.Price);
            ViewBag.avgReview = context.Courses.Average(x => x.Review);
            ViewBag.avgGetOver30Price = context.Courses.Where(x => x.Price>30).Count();
			ViewBag.lastCoursePrice = context.Courses.Where(x => x.CourseID == 2).Select(y => y.Price).FirstOrDefault();
			ViewBag.getTitleByCourseID2 = context.Courses.Where(x => x.CategoryID == 2).Select(y => y.CourseTitle).FirstOrDefault();
			ViewBag.softwareCourseCount = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Yazılım").Select(z => z.CategoryID).FirstOrDefault())).Count();
			ViewBag.maxCoursePrice=context.Courses.Max(x=> x.Price);
            ViewBag.minCoursePrice = context.Courses.Min(x => x.Price);
			ViewBag.mostExpensiveCourse=context.Courses.Where(x=>x.Price==(context.Courses.Max(y=>y.Price))).Select(z=>z.CourseTitle).FirstOrDefault();

			ViewBag.lastCourseTitle = context.Courses.Where(x => x.CourseID == (context.Courses.Max(y => y.CourseID))).Select(z => z.CourseTitle).FirstOrDefault();
			ViewBag.avgPriceForSoftwareCourse = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Yazılım").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
			ViewBag.last3CourseTotalPrice = context.Courses.OrderByDescending(x => x.CourseID).Take(3).Sum(y=>y.Price);
			ViewBag.getCourseCategoryAndSoftware = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Yazılım").Select(z => z.CategoryID).FirstOrDefault()) && x.Review >= 9).Select(w => w.CourseTitle).FirstOrDefault();
            return View();
		}
	}
}
//