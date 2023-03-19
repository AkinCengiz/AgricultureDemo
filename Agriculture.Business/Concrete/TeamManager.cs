using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Business.Abstract;
using Agriculture.DataAccess.Abstract;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;

namespace Agriculture.Business.Concrete
{
    public class TeamManager : GenericManager<Team,EfTeamDal>,ITeamService
    {
        
    }
}
