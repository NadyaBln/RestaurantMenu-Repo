using AutoMapper;
using RestaurantMenu_Entities.Entities;
using RestaurantMenu_WebApi.Models;

namespace RestaurantMenu_WebApi.MappingProfiles
{
    public class DIMappingProfile : Profile
    {
        //create profile to add it to startup file
        public DIMappingProfile()
        {
            this.CreateMap<Orders, OrderModel>();
            this.CreateMap<OrderModel, Orders>();
        }
    }
}
