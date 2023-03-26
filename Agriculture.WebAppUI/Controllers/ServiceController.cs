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

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceManager.Add(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteService(int id)
        {
            Service service = _serviceManager.GetById(s => s.ServiceId == id);
            return View(service);
        }

        [HttpPost]
        public IActionResult DeleteService(Service service)
        {
            _serviceManager.Delete(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            Service service = _serviceManager.GetById(s => s.ServiceId == id);
            return View(service);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceManager.Update(service);
            return RedirectToAction("Index");
        }
    }
}
