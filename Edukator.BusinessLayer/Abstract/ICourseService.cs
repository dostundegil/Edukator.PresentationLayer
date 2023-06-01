using Edukator.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Abstract
{
    public interface ICourseService:IGenericService<Course>
    {
        List<Course> TGetCoursesWithCategory();
        public List<Course> TGetCourseswithCategories();

        List<Course> TGetLast5Course();
    }
}
