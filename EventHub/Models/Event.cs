using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public  class Event
    {
        public string? EventSponsor { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl{ get; set; }
        public TimeOnly StartTime { get; set; }
        public DayOfWeek EventDate { get; set; }
       
    }
}
