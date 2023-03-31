using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
    public class _ContactPartial : ViewComponent
    {
        private readonly ContactManager _contactManager;

        public _ContactPartial()
        {
            _contactManager = new ContactManager(new EfContactDal());
        }

        public IViewComponentResult Invoke()
        {
            List<Contact> contacts = _contactManager.GetList();
            return View(contacts);
        }
    }
}
