using Microsoft.EntityFrameworkCore;
using RestaurantMenu_Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantMenu_DataAccess.Repositories
{
    //create interface
    public interface IOrderRepository
    {
        //add each method in interface
        Task<ICollection<Orders>> GetAllAsync();
        Task AddAsync(Orders orders);
        Task UpdateAsync(Orders orders);
        Task<Orders> GetByIdAsync(int id);
        Task DeleteAsync(Orders orders);
    }
    //OrderRepository - class which allows us to work with DB
    class OrderRepository : IOrderRepository
    {
        //reference to MenuDataContext
        private readonly MenuDataContext _context;

        //initiate this field via constructor
        public OrderRepository(MenuDataContext context)
        {
            this._context = context;
        }

        public async Task<ICollection<Orders>> GetAllAsync()
        {
            return (ICollection<Orders>)await this._context.Orders.ToListAsync();
        }

        public async Task AddAsync(Orders orders)
        {
            await this._context.Orders.AddAsync(orders);
        }

        public async Task UpdateAsync(Orders orders)
        {
            this._context.Orders.Update(orders);
            await this._context.SaveChangesAsync();
        }

        public async Task<Orders> GetByIdAsync(int id)
        {
            return await this._context.Orders.FirstOrDefaultAsync(x => x.OrderId == id);
        }

        public async Task DeleteAsync(Orders orders)
        {
            this._context.Orders.Remove(orders);
            await this._context.SaveChangesAsync();
        }
    }
}
