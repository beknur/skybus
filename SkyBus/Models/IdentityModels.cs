using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SkyBus.Models
{
    // Чтобы добавить данные профиля для пользователя, можно добавить дополнительные свойства в класс ApplicationUser. Дополнительные сведения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Domain.Entities.Bus> Buses { get; set; }

        public System.Data.Entity.DbSet<SkyBus.Models.Ticket> Tickets { get; set; }

        public System.Data.Entity.DbSet<SkyBus.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<SkyBus.Models.Passenger> Passengers { get; set; }

        public System.Data.Entity.DbSet<SkyBus.Models.Race> Races { get; set; }

        public System.Data.Entity.DbSet<SkyBus.Models.Schedule> Schedules { get; set; }

        public System.Data.Entity.DbSet<SkyBus.Models.Seat> Seats { get; set; }

        public System.Data.Entity.DbSet<SkyBus.Models.Station> Stations { get; set; }
    }
}