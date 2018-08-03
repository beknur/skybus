using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkyBus.Models
{
    public class City
    {
        public int Id { get; set; }
        public int StationId { get; set; }
        public int CityNumber { get; set; }
        public string CityName { get; set; }
    }
}