using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Agriculture.DataAccess.Contexts
{
    public class AgricultureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=DESKTOP-U0NLI58\\MSSQLSERVER01; database=DbAgriculture; integrated security=true; TrustServerCertificate=True;");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
