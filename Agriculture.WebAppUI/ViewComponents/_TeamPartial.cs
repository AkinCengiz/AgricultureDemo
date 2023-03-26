
using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
    public class _TeamPartial : ViewComponent
    {
        private readonly TeamManager _teamManager;

        public _TeamPartial()
        {
            _teamManager = new TeamManager(new EfTeamDal());
        }

        public IViewComponentResult Invoke()
        {
            List<Team> teams = _teamManager.GetList();
            return View(teams);
        }
    }
}
