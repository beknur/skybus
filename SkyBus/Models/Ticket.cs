using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBus.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int BusId { get; set; }
        public int CityId { get; set; }
        public int PassengerId { get; set; }
    }
}