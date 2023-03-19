using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Abstract;

namespace Agriculture.Entities.Concrete
{
    public class Announcement : IEntity
    {
        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
