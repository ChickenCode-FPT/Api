using API.Application.Restaurant.Dtos;
using API.Domain.Entities;
using API.Domain.Respositories;
using AutoMapper;
using Microsoft.Extensions.Logging;
namespace API.Application.Restaurant
{
    public class RestaurantsServices(IRestaurantsRepository restaurantsRepository,
        ILogger<RestaurantsServices> logger,IMapper mapper) : IRestaurantsServices
    {
        public async Task<int> Create(CreateRestaurantDto dto)
        {
            logger.LogInformation("Create one restaurants");    
            var restaurant = mapper.Map<Restaurants>(dto);
            int id = await restaurantsRepository.Create(restaurant);
            return id;
        }

        public async Task<IEnumerable<RestaurantsDtos>> GetAllRestaurants()
        {
            logger.LogInformation("Getting all information");
            var restaurants = await restaurantsRepository.GetAllAsync();
            var restaurantDtos = mapper.Map<IEnumerable<RestaurantsDtos>>(restaurants);
            return restaurantDtos;
        }

        public async Task<RestaurantsDtos> GetOneRestaurants(int id)
        {
            logger.LogInformation("Getting a information");
            var restaurants = await restaurantsRepository.GetOneAsync(id);
            var restaurantDto = mapper.Map<RestaurantsDtos>(restaurants);
            return restaurantDto;
        }
    }
}
