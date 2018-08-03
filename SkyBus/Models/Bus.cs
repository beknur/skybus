using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBus.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public int SeatId { get; set; }
        public string Number { get; set; }
        public string Driver { get; set; }
    }
}