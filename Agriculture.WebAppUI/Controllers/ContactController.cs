using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactManager _contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            List<Contact> contacts = _contactManager.GetList();
            return View(contacts);
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactManager.Add(contact);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            Contact contact = _contactManager.GetById(c => c.ContactId == id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            _contactManager.Update(contact);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteContact(int id)
        {
            Contact contact = _contactManager.GetById(cc => cc.ContactId == id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult DeleteContact(Contact contact)
        {
            _contactManager.Delete(contact);
            return RedirectToAction("Index");
        }
    }
}
