using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Data
{
    public class BusRepository: IBusRepository
    {
        public IEnumerable<Bus> GetBuses()
        {
            var buses = new List<Bus>();
            buses.Add(new Bus
            {
                Driver = "Driver1"

            });
            return buses;
        }
    }
}
