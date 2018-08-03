using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBus.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}