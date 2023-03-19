using Agriculture.Business.Concrete;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.Controllers
{
    public class DefaultController : Controller
    {
        TeamManager _teamManager = new TeamManager();
        public IActionResult Index()
        {
            var values = _teamManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            _teamManager.Add(team);
            return RedirectToAction("Index");
        }
    }
}
