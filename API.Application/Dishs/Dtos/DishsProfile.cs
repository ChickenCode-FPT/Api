using AutoMapper;
using API.Domain.Entities;
namespace API.Application.Dishs.Dtos
{
    public class DishsProfile : Profile
    {
        public DishsProfile()
        {
            CreateMap<API.Domain.Entities.Dishs, DishsDtos>();
        }
    }
}
