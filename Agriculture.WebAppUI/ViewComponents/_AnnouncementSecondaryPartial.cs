using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Agriculture.WebAppUI.ViewComponents
{
    public class _AnnouncementSecondaryPartial : ViewComponent
    {
        private readonly AnnouncementManager _announcementManager;

        public _AnnouncementSecondaryPartial()
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
