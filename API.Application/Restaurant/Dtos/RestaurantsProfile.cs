using API.Domain.Entities;
using AutoMapper;

namespace API.Application.Restaurant.Dtos
{
    public class RestaurantsProfile : Profile
    {
        public RestaurantsProfile()
        {
            CreateMap<Restaurants, RestaurantsDtos>()
                .ForMember(d => d.City,opt => 
                    opt.MapFrom(src => src.Address == null ? null : src.Address.City))
                 .ForMember(d => d.Street, opt =>
                    opt.MapFrom(src => src.Address == null ? null : src.Address.Street))
                 .ForMember(d => d.PostalCode, opt =>
                    opt.MapFrom(src => src.Address == null ? null : src.Address.PostalCode))
                 .ForMember(d => d.Dishes, opt =>
                    opt.MapFrom(src => src.Dishes))
                ;
        }
    }
}
