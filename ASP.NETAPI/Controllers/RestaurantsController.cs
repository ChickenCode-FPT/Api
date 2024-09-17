using API.Application.Restaurant;
using API.Application.Restaurant.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETAPI.Controllers
{
    [ApiController]
    [Route("api/restaurants")]
    public class RestaurantsController(IRestaurantsServices restaurantsServices) : ControllerBase
    {
        [HttpGet]
        public  async Task<IActionResult> GetAll() {
            var restaurant = await restaurantsServices.GetAllRestaurants();
            return Ok(restaurant);
        }
        [HttpGet("{id}")] 
        public async Task<IActionResult> Get(int id)
        {
            var restaurant = await restaurantsServices.GetOneRestaurants(id);
            return Ok(restaurant);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRestaurant([FromBody] CreateRestaurantDto createRestaurantDto)
        {
            int id = await restaurantsServices.Create(createRestaurantDto);
            return CreatedAtAction(nameof(Get), new {id},null );
        }
    }
}
