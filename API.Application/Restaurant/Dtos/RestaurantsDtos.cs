
using API.Application.Dishs.Dtos;
using API.Domain.Entities;

namespace API.Application.Restaurant.Dtos
{
    public class RestaurantsDtos
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Category { get; set; } = default!;
        public bool HasDelivery { get; set; }

        public string? City { get; set; }
        public string? Street { get; set; }
        public string? PostalCode { get; set; }
        public List<DishsDtos> Dishes { get; set; } = [];
        
    }
}
