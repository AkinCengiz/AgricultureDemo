using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.Controllers
{
    public class ImageController : Controller
    {
        private readonly ImageManager _imageManager = new ImageManager(new EfImageDal());

        public IActionResult Index()
        {
            List<Image> images = _imageManager.GetList();
            return View(images);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddImage(Image image)
        {
            _imageManager.Add(image);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteImage(int id)
        {
            Image image = _imageManager.GetById(i => i.ImageId == id);
            return View(image);
        }

        [HttpPost]
        public IActionResult DeleteImage(Image image)
        {
            _imageManager.Delete(image);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateImage(int id)
        {
            Image image = _imageManager.GetById(i => i.ImageId == id);
            return View(image);
        }

        [HttpPost]
        public IActionResult UpdateImage(Image image)
        {
            _imageManager.Update(image);
            return RedirectToAction("Index");
        }
    }
}
