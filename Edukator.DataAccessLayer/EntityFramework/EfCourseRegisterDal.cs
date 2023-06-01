using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrate;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCourseRegisterDal : GenericRepository<CourseRegister>, ICourseRegisterDal
    {
        public List<CourseRegister> CourseRegisterListWithCourseByUser(int id)
        {
            using var context = new Context();
            var value = context.CourseRegisters.Where(y => y.AppUserID == id).Include(x => x.Course).ToList();
            return value;
        }

        public List<CourseRegister> CourseRegisterListWithCoursesAndUsers()
        {
            using var context = new Context();
            var values = context.CourseRegisters.Include(x => x.Course).Include(y => y.AppUser).ToList();
            return values;
        }
    }
}
