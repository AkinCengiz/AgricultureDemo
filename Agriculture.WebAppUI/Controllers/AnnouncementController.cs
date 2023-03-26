using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementManager.GetList();
            return View(announcements);
        }

        
        
        public IActionResult ChangesStatu(int id)
        {
            Announcement announcement = _announcementManager.GetById(a => a.AnnouncementId == id);
            if (announcement.Status)
            {
                _announcementManager.MakeStatusFalse(id);
            }
            else
            {
                _announcementManager.MakeStatusTrue(id);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            Announcement announcement = _announcementManager.GetById(a => a.AnnouncementId == id);
            return View(announcement);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(Announcement announcement)
        {
            _announcementManager.Update(announcement);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            announcement.Status = true;
            _announcementManager.Add(announcement);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteAnnouncement(int id)
        {
            Announcement announcement = _announcementManager.GetById(a => a.AnnouncementId == id);
            return View(announcement);
        }

        [HttpPost]
        public IActionResult DeleteAnnouncement(Announcement announcement)
        {
            _announcementManager.Delete(announcement);
            return RedirectToAction("Index");
        }


    }
}
