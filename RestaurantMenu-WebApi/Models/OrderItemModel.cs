using Microsoft.AspNetCore.Mvc;
using RestaurantMenu_Entities.Entities;
using System.Collections.Generic;
namespace RestaurantMenu_WebApi.Models
{
    public class OrderItemModel : Controller
    {
        public int? OrderItemId { get; set; }
        public int OrderId { get; set; }
        //public virtual OrderModel Order { get; set; }
        public int ProductId { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        
        //public virtual ProductModel Product { get; set; }
    }
}
