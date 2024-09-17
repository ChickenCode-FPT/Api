using API.Domain.Entities;
using API.Domain.Respositories;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Respositories
{
    internal class RestaurantsRepository(RestaurantsDbContext restaurantsDbContext) : IRestaurantsRepository
    {
        public async Task<int> Create(Restaurants entity)
        {
            restaurantsDbContext.Restaurants.Add(entity);
            await restaurantsDbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<IEnumerable<Restaurants>> GetAllAsync()
        {
            var restaurants = await restaurantsDbContext.Restaurants
                .Include(r => r.Dishes)
                .ToListAsync();
            return restaurants;
        }

        public async Task<Restaurants> GetOneAsync(int id)
        {       
            var oneRestaurants = await restaurantsDbContext.Restaurants
                .Include(r => r.Dishes)
                .FirstOrDefaultAsync(r => r.Id == id);
            return oneRestaurants;

        }

    }
}
