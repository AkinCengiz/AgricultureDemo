using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
    public class _BottomSocialPartial : ViewComponent
    {
        private readonly SocialManager _socialManager;

        public _BottomSocialPartial()
        {
            _socialManager = new SocialManager(new EfSocialDal());
        }

        public IViewComponentResult Invoke()
        {
            List<Social> socials = _socialManager.GetList();
            return View(socials);
        }
    }
}
