﻿using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
