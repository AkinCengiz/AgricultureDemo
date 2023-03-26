using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Concrete;

namespace Agriculture.Business.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        void MakeStatusFalse(int id);
        void MakeStatusTrue(int id);
    }
}
