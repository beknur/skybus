using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Services.Interfaces;

namespace Services
{
    public class BusService : IBusService
    {

        private readonly IBusRepository _busRepository;

        public BusService(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }


        public IEnumerable<Bus> GetBuses()
        {
            return _busRepository.GetBuses();
        }

    }
}
