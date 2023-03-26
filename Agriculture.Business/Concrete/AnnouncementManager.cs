using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Business.Abstract;
using Agriculture.DataAccess.Abstract;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;

namespace Agriculture.Business.Concrete
{
    public class AnnouncementManager : GenericManager<Announcement, EfAnnouncementDal>, IAnnouncementService
    {
        private IAnnouncementDal _announcementDal;
       


        public void MakeStatusFalse(int id)
        {
            _announcementDal.MakeStatusFalse(id);
        }

        public void MakeStatusTrue(int id)
        {
            _announcementDal.MakeStatusTrue(id);
        }

        public AnnouncementManager(EfAnnouncementDal genericDal) : base(genericDal)
        {
            _announcementDal = genericDal;
        }
    }
}
