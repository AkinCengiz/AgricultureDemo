using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Business.Abstract;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;

namespace Agriculture.Business.Concrete
{
    public class AnnouncementManager : GenericManager<Announcement, EfAnnouncementDal>, IAnnouncementService
    {
        public AnnouncementManager(EfAnnouncementDal genericDal) : base(genericDal)
        {
        }
    }
}
