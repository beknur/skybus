using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBus.Models
{
    public class Station
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public string Name { get; set; }
    }
}