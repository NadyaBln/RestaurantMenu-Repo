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
        Task UpdateAsync(Orders orders);
        Task<bool> TryUpdateAsync(int id, Orders order);
        Task<Orders> GetByIdAsync(int id);
        Task DeleteAsync(Orders orders);
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

        public Task UpdateAsync(Orders orders)

            => this._repository.UpdateAsync(orders);

        public Task<Orders> GetByIdAsync(int id)
           => this._repository.GetByIdAsync(id);

        public async Task<bool> TryUpdateAsync(int id, Orders order)
        {
            var orderToUpdate = await this._repository.GetByIdAsync(id);
            if (orderToUpdate != null)
            {
                orderToUpdate.CreationDateTime = order.CreationDateTime;
                orderToUpdate.Guest = order.Guest;
                orderToUpdate.TableNumber = order.TableNumber;

                await this._repository.UpdateAsync(orderToUpdate);

                return true;
            }
            return false;
        }

        public Task DeleteAsync(Orders orders)
            => this._repository.DeleteAsync(orders);
    }
}
