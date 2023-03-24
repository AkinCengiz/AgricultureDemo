﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Business.Abstract;
using Agriculture.DataAccess.Concrete.EntityFramework;
using Agriculture.Entities.Concrete;

namespace Agriculture.Business.Concrete
{
    public class ServiceManager : GenericManager<Service, EfServiceDal>, IServiceService
    {
        public ServiceManager(EfServiceDal genericDal) : base(genericDal)
        {
        }
    }
}
