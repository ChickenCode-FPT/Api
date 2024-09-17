using API.Application.Dishs.Dtos;
using API.Domain.Entities;
using AutoMapper;
using API.Application.Dishs.Dtos;
namespace API.Application.Restaurant.Dtos
{
    public class RestaurantsProfile : Profile
    {
        public RestaurantsProfile()
        {
            CreateMap<CreateRestaurantDto, Restaurants>()
                .ForMember(d => d.Address, opt => opt.MapFrom(
                        src => new Address
                        {
                            City = src.City,
                            PostalCode = src.PostalCode,
                            Street = src.Street,
                        }
                    ))
                .ForMember(d => d.Dishes, opt => opt.MapFrom(
                        src => src.Dishes                       
                    ))
                ;
            CreateMap<API.Application.Dishs.Dtos.CreateDishsDto, Dishes>();
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
