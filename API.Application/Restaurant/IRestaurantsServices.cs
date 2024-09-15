using API.Application.Restaurant.Dtos;
using API.Domain.Entities;

namespace API.Application.Restaurant
{
    public interface IRestaurantsServices
    {
        Task<IEnumerable<RestaurantsDtos>> GetAllRestaurants();
        Task<RestaurantsDtos> GetOneRestaurants(int id);
    }
}