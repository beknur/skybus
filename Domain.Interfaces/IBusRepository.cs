using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IBusRepository
    {
        IEnumerable<Bus> GetBuses();
    }
}
