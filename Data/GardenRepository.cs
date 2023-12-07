using GreenThumbProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumbProject.Data
{
    public class GardenRepository<T> where T : class
    {
        private readonly MyDBContext _context;

        public GardenRepository(MyDBContext context)
        {
            _context = context;
        }

        public async Task<Garden?> GetGardenByUserIdAsync(int enteredUserId)
        {
            return await _context.Set<T>()
                .OfType<Garden>()
                .FirstOrDefaultAsync(g => g.UserId == enteredUserId);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entityToDelete = await _context.Set<T>().FindAsync(id);

            if (entityToDelete != null)
            {
                _context.Set<T>().Remove(entityToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}