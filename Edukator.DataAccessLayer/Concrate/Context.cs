using Edukator.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Concrate
{
    public class Context: IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-QEJG79H\\MSSQLSERVER01;initial catalog=DbEdukator;integrated security=true");
        }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ContactInfo> ContactInfos { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Service> Services { get; set; }

		public DbSet<Feature> Features { get; set; }

        public DbSet<AboutGrid> AboutGrids { get; set; }

        public DbSet<MailSubscribe> MailSubscribes { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<AboutUs> AboutUss { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MapInfo> MapInfos { get; set; }

        public DbSet<CourseRegister> CourseRegisters { get; set; }
    }
}
