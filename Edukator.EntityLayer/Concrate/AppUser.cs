using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrate
{
	public class AppUser:IdentityUser<int>
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public string City { get; set; }

		[StringLength(256)]

        public string ImageUrl { get; set; }

        public List<CourseRegister> CourseRegisters { get; set; }
    }
}
