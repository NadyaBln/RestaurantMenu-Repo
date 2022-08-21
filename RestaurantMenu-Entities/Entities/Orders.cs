using System;

namespace RestaurantMenu_Entities.Entities
{
   public class Orders
    {
        public int OrderId { get; set; }
        //public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }
        public DateTime CreationDateTime { get; set; }
        //public int GuestId { get; set; }
        public Guest Guest { get; set; }
        public int TableNumber { get; set; }
    }
}
