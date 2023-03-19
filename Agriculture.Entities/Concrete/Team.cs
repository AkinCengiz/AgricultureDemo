using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Abstract;

namespace Agriculture.Entities.Concrete
{
    public class Team : IEntity
    {
        public int TeamId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string WebsiteUrl { get; set; }
        public string TwitterUrl { get; set; }

    }
}
