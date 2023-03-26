using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
    public class _ImagePartial : ViewComponent
    {
        private readonly ImageManager _imageManager;

        public _ImagePartial()
        {
            _imageManager = new ImageManager(new EfImageDal());
        }

        public IViewComponentResult Invoke()
        {
            List<Image> images = _imageManager.GetList();
            return View(images);
        }
    }
}
