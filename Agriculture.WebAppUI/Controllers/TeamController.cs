using Agriculture.Business.Concrete;
using Agriculture.Business.ValidationRules;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Agriculture.WebAppUI.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.Controllers
{
    public class TeamController : Controller
    {
        TeamManager _teamManager = new TeamManager(new EfTeamDal());
        public IActionResult Index()
        {
            var values = _teamManager.GetList();
            return View(values);
        }

        //[HttpGet]
        //public IActionResult AddTeam()
        //{
        //    return View(new TeamAddViewModel());
        //}


        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            TeamValidator teamValidator = new TeamValidator();
            ValidationResult result = teamValidator.Validate(team);
            if (result.IsValid)
            {
                _teamManager.Add(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);

                }
            }

            return View();
        }

        //[HttpPost]
        //public IActionResult AddTeam(TeamAddViewModel teamAddViewModel)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        Team team = new Team()
        //        {
        //            FirstName = teamAddViewModel.FirstName,
        //            LastName = teamAddViewModel.LastName,
        //            Title = teamAddViewModel.Title,
        //            ImageUrl = teamAddViewModel.ImageUrl,
        //            FacebookUrl = teamAddViewModel.FacebookUrl,
        //            InstagramUrl = teamAddViewModel.InstagramUrl,
        //            WebsiteUrl = teamAddViewModel.WebsiteUrl,
        //            TwitterUrl = teamAddViewModel.TwitterUrl
        //        };
        //        _teamManager.Add(team);
        //        return RedirectToAction("Index");
        //    }

        //    return View(teamAddViewModel);
        //}

        [HttpGet]
        public IActionResult DeleteTeam(int id)
        {
            var team = _teamManager.GetById(t=> t.TeamId == id);
            return View(team);
        }

        [HttpPost]
        public IActionResult DeleteTeam(Team team)
        {
            _teamManager.Delete(team);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            var team = _teamManager.GetById(t => t.TeamId == id);
            return View(team);
        }

        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            _teamManager.Update(team);
            return RedirectToAction("Index");
        }

        public IActionResult Deneme()
        {
            return View();
        }
    }
}
