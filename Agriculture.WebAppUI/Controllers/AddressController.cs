using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.Controllers
{
    public class AddressController : Controller
    {
        private readonly AddressManager _addressManager = new AddressManager(new EfAddressDal());
        public IActionResult Index()
        {
            List<Address> addresses = _addressManager.GetList();
            return View(addresses);
        }

        [HttpGet]
        public IActionResult UpdateAddress(int id)
        {
            Address address = _addressManager.GetById(a => a.AddressId == id);
            return View(address);
        }

        [HttpPost]
        public IActionResult UpdateAddress(Address address)
        {
            _addressManager.Update(address);
            return RedirectToAction("Index");
        }
    }
}
