using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.DataAccess.Abstract;
using Agriculture.DataAccess.Concrete.Repository;
using Agriculture.DataAccess.Contexts;
using Agriculture.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Agriculture.DataAccess.Concrete.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement,AgricultureContext>,IAnnouncementDal
    {
        public void MakeStatusFalse(int id)
        {
            using (var context = new AgricultureContext())
            {
                Announcement announcement = context.Announcements.SingleOrDefault(a => a.AnnouncementId == id);
                announcement.Status = false;
                context.SaveChanges();
            }
        }

        public void MakeStatusTrue(int id)
        {
            using (var context = new AgricultureContext())
            {
                Announcement announcement = context.Announcements.Find(id);
                announcement.Status = true;
                context.SaveChanges();
            }
        }
    }
}
