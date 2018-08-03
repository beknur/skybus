using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBus.Models
{
    public class Race
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public int StationId { get; set; }
        public string DeparturePlace { get; set; }
        public string ArrivalPlace { get; set; }
    }
}