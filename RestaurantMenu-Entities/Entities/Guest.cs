
using System.Collections.Generic;

namespace RestaurantMenu_Entities.Entities
{
   public class Guest
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public string GuestEmail { get; set; }
        public bool IsAdmin { get; set; }
       // public virtual ICollection<OrderItem> Items { get; set; }

    }
}
