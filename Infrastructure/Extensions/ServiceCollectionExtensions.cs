using API.Domain.Respositories;
using Infrastructure.Persistence;
using Infrastructure.Respositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("RestaurantsDB");
            services.AddDbContext<RestaurantsDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IRestaurantsRepository, RestaurantsRepository>();
        }
    }
}
