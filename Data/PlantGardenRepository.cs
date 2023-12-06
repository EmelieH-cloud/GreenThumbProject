using GreenThumbProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumbProject.Data
{
    public class PlantGardenRepository<T> where T : class
    {
        private readonly MyDBContext _context;
        private readonly DbSet<T> _dbSet;

        public PlantGardenRepository(MyDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        // GetPlantGardenbyGardenId()
        // Metod som hämtar alla plantgardens som har samma gardenid. 
        public async Task<List<PlantGarden>> GetPlantGardenbyGardenIdAsync(int gardenId)
        {

            return await _dbSet.OfType<PlantGarden>().Where(pgarden => pgarden.GardenId == gardenId).ToListAsync();

        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

    }
}

