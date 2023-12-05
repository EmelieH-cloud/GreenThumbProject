using GreenThumbProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumbProject.Data
{
    public class GardenRepository<T> where T : class
    {
        private readonly MyDBContext _context;
        private readonly DbSet<T> _dbSet;

        public GardenRepository(MyDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<Garden?> GetGardenByUserIdAsync(int enteredUserId)
        {
            var garden = await _dbSet.OfType<Garden>().FirstOrDefaultAsync(g => g.UserId == enteredUserId);
            if (garden != null)
            {
                return garden;
            }

            else
            {
                return null;
            }

        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);

        }
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entityToDelete = await _dbSet.FindAsync(id);

            if (entityToDelete != null)
            {
                _dbSet.Remove(entityToDelete);
            }

        }
    }
}