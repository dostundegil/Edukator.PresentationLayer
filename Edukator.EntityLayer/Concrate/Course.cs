using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrate
{
    public class Course
    {
        public int CourseID { get; set; }

        public string CourseTitle { get; set; }

        public string CourseDescription { get; set; }

        public decimal Price { get; set; }

        public int Review { get; set; }
    }
}
