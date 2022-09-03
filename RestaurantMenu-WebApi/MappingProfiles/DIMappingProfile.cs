using AutoMapper;
using RestaurantMenu_Entities.Entities;
using RestaurantMenu_WebApi.Models;
using System;

namespace RestaurantMenu_WebApi.MappingProfiles
{
    public class DIMappingProfile : Profile
    {
        //create profile to add it to startup file
        public DIMappingProfile()
        {
            this.CreateMap<Orders, OrderModel>();
            this.CreateMap<OrderModel, Orders>();
                //.ForMember(x => x.OrderItem, src => src.Ignore());

            this.CreateMap<Product, ProductModel>();
            this.CreateMap<ProductModel, Product>()
                .ForMember(x => x.ProductId, src => src.Ignore());

            this.CreateMap<Guest, GuestModel>();
            this.CreateMap<GuestModel, Guest>()
                .ForMember(x => x.GuestId, src => src.Ignore());

            this.CreateMap<OrderItem, OrderItemModel>();
            //.ForMember(x => x.Order, src => src.MapFrom(x => $"{GetOrder(x.Order.OrderId)} {x.Order.OrderItemId}"));
            this.CreateMap<OrderItemModel, OrderItem>();
                //.ForMember(x => x.Order, src => src.Ignore());
        }

        private object GetOrder(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
