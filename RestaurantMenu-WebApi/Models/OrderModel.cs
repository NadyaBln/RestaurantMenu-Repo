
using System;

namespace RestaurantMenu_WebApi.Models
{
    public class OrderModel
    {
        //public int OrderId { get; set; }
        //public int OrderItemId { get; set; }
        public OrderItemModel OrderItem { get; set; }
        public GuestModel Guest { get; set; }
        //public int GuestId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int TableNumber { get; set; }
    }
}
