using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Abstract;

namespace Agriculture.Entities.Concrete
{
    public class Social : IEntity
    {
        public int SocialId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; } 

    }
}
