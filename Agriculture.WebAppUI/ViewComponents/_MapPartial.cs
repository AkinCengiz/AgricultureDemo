using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
	public class _MapPartial : ViewComponent
	{
		private readonly AddressManager _addressManager;

		public _MapPartial()
		{
			_addressManager = new AddressManager(new EfAddressDal());
		}

		public IViewComponentResult Invoke()
		{
			List<Address> addresses = _addressManager.GetList();
			return View(addresses);
		}
	}
}
