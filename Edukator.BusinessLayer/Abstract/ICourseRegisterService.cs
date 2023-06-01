using Edukator.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Abstract
{
    public interface ICourseRegisterService:IGenericService<CourseRegister>
    {
        List<CourseRegister> TCourseRegisterListWithCoursesAndUsers();

        List<CourseRegister> TCourseRegisterListWithCourseByUser(int id);
    }
}
