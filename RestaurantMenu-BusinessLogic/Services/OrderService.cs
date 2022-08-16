using RestaurantMenu_DataAccess.Repositories;
using RestaurantMenu_Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

//add new layer - business logic

namespace RestaurantMenu_BusinessLogic.Services
{
    //create interface
    public interface IOrderService
    {
        //add all methods from Controller
        //it is the same as in OrderRepository
        Task<ICollection<Orders>> GetAllAsync();
        Task AddAsync(Orders orders);
    }
    public class OrderService : IOrderService
    {
        //reference to OrderRepository
        private readonly IOrderRepository _repository;

        //initialization via constructor
        public OrderService(IOrderRepository repository)
        {
            this._repository = repository;
        }

        //method calls method GetAllAsync from abstraction 
        public Task<ICollection<Orders>> GetAllAsync()
        {
            var ordersFromRepository = this._repository.GetAllAsync();
            return ordersFromRepository;
        }

        public Task AddAsync(Orders orders)
           => this._repository.AddAsync(orders);
    }
}
