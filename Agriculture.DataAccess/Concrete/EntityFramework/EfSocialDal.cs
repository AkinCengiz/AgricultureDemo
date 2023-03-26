using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.DataAccess.Abstract;
using Agriculture.DataAccess.Concrete.Repository;
using Agriculture.DataAccess.Contexts;
using Agriculture.Entities.Concrete;

namespace Agriculture.DataAccess.Concrete.EntityFramework
{
    public class EfSocialDal : GenericRepository<Social,AgricultureContext>,ISocialDal
    {
    }
}
