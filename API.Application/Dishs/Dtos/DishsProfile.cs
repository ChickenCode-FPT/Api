using AutoMapper;
using API.Domain.Entities;
using API.Application.Restaurant.Dtos;
namespace API.Application.Dishs.Dtos
{
    public class DishsProfile : Profile
    {
        public DishsProfile()
        {
            CreateMap<API.Domain.Entities.Dishes, DishsDtos>();
            CreateMap<CreateDishsDto, Dishes>();
        }
    }
}
