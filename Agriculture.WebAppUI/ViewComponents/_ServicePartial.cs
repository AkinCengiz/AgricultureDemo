using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
    public class _ServicePartial : ViewComponent
    {
        private readonly ServiceManager _serviceManager;

        public _ServicePartial()
        {
            _serviceManager = new ServiceManager(new EfServiceDal());
        }

        public IViewComponentResult Invoke()
        {
            List<Service> services = _serviceManager.GetList();
            return View(services);
        }
    }
}
