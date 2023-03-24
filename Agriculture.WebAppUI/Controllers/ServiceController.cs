using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager _serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            var services = _serviceManager.GetList();
            return View(services);
        }
    }
}
