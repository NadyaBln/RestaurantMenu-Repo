using Microsoft.EntityFrameworkCore;
using RestaurantMenu_Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantMenu_DataAccess.Repositories
{
    //create interface
    public interface IGuestRepository
    {
        //add each method in interface
        Task<ICollection<Guest>> GetAllAsync();
        Task AddAsync(Guest guest);
        Task UpdateAsync(Guest guest);
        Task<Guest> GetByIdAsync(int id);
        Task DeleteAsync(Guest guest);
    }
    //OrderRepository - class which allows us to work with DB
    class GuestRepository : IGuestRepository
    {
        //reference to MenuDataContext
        private readonly MenuDataContext _context;

        //initiate this field via constructor
        public GuestRepository(MenuDataContext context)
        {
            this._context = context;
        }

        public async Task<ICollection<Guest>> GetAllAsync()
        {
            return (ICollection<Guest>)await this._context.Guest.ToListAsync();
        }

        public async Task AddAsync(Guest guest)
        {
            await this._context.Guest.AddAsync(guest);
        }

        public async Task UpdateAsync(Guest guest)
        {
            this._context.Guest.Update(guest);
            await this._context.SaveChangesAsync();
        }

        public async Task<Guest> GetByIdAsync(int id)
        {
            return await this._context.Guest.FirstOrDefaultAsync(x => x.GuestId == id);
        }

        public async Task DeleteAsync(Guest guest)
        {
            this._context.Guest.Remove(guest);
            await this._context.SaveChangesAsync();
        }
    }
}
