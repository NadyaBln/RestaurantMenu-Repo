
using System.Collections.Generic;

namespace RestaurantMenu_Entities.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        //public int OrderId { get; set; }
        public Orders Order { get; set; }
        //public List<Product> ProductId { get; set; }
        public List<Product> Product { get; set; }
        
    }
}
