using System;

namespace RestaurantMenu_WebApi.Models
{
    public class OrderModel 
    {
        public int OrderItemId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int GuestId { get; set; }
        public int TableNumber { get; set; }
    }
}
