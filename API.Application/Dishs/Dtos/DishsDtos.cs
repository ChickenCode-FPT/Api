using API.Domain.Entities;
namespace API.Application.Dishs.Dtos
{
    public class DishsDtos
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public double Price { get; set; } = default!;

        public int? KiloCarlo { get; set; } = default!;

    }
}
