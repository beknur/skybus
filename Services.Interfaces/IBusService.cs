using System.Collections.Generic;
using Domain.Entities;

namespace Services.Interfaces
{
   public interface IBusService
    {
       IEnumerable<Bus> GetBuses();
    }
}
