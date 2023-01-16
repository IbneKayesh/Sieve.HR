using Microsoft.EntityFrameworkCore;
using Sieve.HR.Infrastructure;

namespace Sieve.HR.Services.Db
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HRDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("HrDbCon2"));
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}


//|:---------:|:------------------------------------------:|:----------------------------------------------------:|:------------------------------------:|
//| Parameter | Add Singleton                              | Add Scoped                                           | Add Transient                        |
//|:---------:|:------------------------------------------:|:----------------------------------------------------:|:------------------------------------:|
//| Instance  | Same for each request/ each user.          | One per request.                                     | Different for every time.            |
//| Disposed  | App shutdown                               | End of request                                       | End of request                       |
//| Used in   | When Singleton implementation is required. | Applications that have different behavior per user.  | Lightweight and stateless services.  |
//|:---------:|:------------------------------------------:|:----------------------------------------------------:|:------------------------------------:|