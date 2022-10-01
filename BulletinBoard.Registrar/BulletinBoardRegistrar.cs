
using BulletinBoard.DataAccess;
using BulletinBoard.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BulletinBoard.Registrar
{
    public static class BulletinBoardRegistrar
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddDbContext<BulletinBoardContext>((sp, dbOptions) => 
            sp.GetRequiredService<IDbContextOptionsConfigurator<BulletinBoardContext>>().Configure((DbContextOptionsBuilder<BulletinBoardContext>) dbOptions));
            services.AddSingleton<IDbContextOptionsConfigurator<BulletinBoardContext>, BulletinBoardContextConfiguration>();
            services.AddScoped(sp => (DbContext) sp.GetRequiredService<BulletinBoardContext>());
            //services.AddScoped((Func<IServiceProvider, DbContext>)(sp => sp.GetRequiredService<BulletinBoardContext>()));

            return services;
        }
    }
}
