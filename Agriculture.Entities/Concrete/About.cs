using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Abstract;

namespace Agriculture.Entities.Concrete
{
    public class About : IEntity
    {
        public int AboutId { get; set; }
        public string AboutHistory { get; set; }
        public string AboutUs { get; set; }
    }
}
