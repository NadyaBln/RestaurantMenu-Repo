
namespace RestaurantMenu_Entities.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsAlcohol { get; set; }
        public bool IsSeason { get; set; }
        public bool IsActive { get; set; }
        public int AllergenId { get; set; }
    }
}
