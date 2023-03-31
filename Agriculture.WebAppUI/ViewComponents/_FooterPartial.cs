using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
	public class _FooterPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
