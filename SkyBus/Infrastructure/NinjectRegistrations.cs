using Domain.Interfaces;
using Infrastructure.Data;
using Ninject.Modules;

namespace SkyBus.Infrastructure
{
    public class NinjectRegistrations: NinjectModule

    {
        public override void Load()
        {
            Bind<IBusRepository>().To<BusRepository>();
            
        }
    }
}