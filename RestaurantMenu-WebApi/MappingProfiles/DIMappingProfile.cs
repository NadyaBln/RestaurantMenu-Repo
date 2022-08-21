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

            this.CreateMap<Product, ProductModel>();
            this.CreateMap<ProductModel, Product>();

            this.CreateMap<Guest, GuestModel>();
            this.CreateMap<GuestModel, Guest>();

            this.CreateMap<OrderItem, OrderItemModel>();
            this.CreateMap<OrderItemModel, OrderItem>();
        }
    }
}
