﻿using Agriculture.Business.Concrete;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agriculture.WebAppUI.ViewComponents
{
    public class _TopAddressPartial : ViewComponent
    {
        private readonly AddressManager _addressManager;
        public _TopAddressPartial()
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
