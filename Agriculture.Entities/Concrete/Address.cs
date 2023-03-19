using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Abstract;

namespace Agriculture.Entities.Concrete
{
    public class Address : IEntity
    {
        public int AddressId { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string BuildNo { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string MapInfo { get; set; }
    }
}
