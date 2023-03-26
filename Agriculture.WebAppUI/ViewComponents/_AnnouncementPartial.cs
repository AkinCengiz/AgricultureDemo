using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
    public class _AnnouncementPartial : ViewComponent
    {
        private readonly AnnouncementManager _announcementManager;

        public _AnnouncementPartial()
        {
            _announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        }

        public IViewComponentResult Invoke()
        {
            List<Announcement> announcements = _announcementManager.GetList().FindAll(a => a.Status == true);
            return View(announcements);
        }
    }
}
