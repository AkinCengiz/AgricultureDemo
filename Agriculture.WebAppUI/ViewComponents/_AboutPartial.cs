using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
    public class _AboutPartial : ViewComponent
    {
        private readonly AboutManager _aboutManager;

        public _AboutPartial()
        {
            _aboutManager = new AboutManager(new EfAboutDal());
        }

        public IViewComponentResult Invoke()
        {
            List<About> abouts = _aboutManager.GetList();
            return View(abouts);
        }
    }
}
