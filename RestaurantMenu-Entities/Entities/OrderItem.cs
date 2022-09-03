
using System.Collections.Generic;

namespace RestaurantMenu_Entities.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        //public int OrderId { get; set; }
        public virtual Orders Order { get; set; }
        //public  int ProductId { get; set; }
        //public virtual Product Product { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}
