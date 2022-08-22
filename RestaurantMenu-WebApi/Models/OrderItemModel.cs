using Microsoft.AspNetCore.Mvc;
using RestaurantMenu_Entities.Entities;
using System.Collections.Generic;
namespace RestaurantMenu_WebApi.Models
{
    public class OrderItemModel : Controller
    {
        //public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        //public Orders Orders { get; set; }
       //public List<Product> Product { get; set; }
        public int[] ProductId { get; set; }
    }
}
