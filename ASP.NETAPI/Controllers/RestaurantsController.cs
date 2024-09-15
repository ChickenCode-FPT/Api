using API.Application.Restaurant;
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
    }
}
