using GreenThumbProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumbProject.Data
{
    public class PlantGardenRepository<T> where T : class
    {
        private readonly MyDBContext _context;

        public PlantGardenRepository(MyDBContext context)
        {
            _context = context;
        }

        public async Task<List<PlantGarden>> GetPlantGardenbyGardenIdAsync(int gardenId)
        {
            return await _context.Set<T>().OfType<PlantGarden>().Where(pgarden => pgarden.GardenId == gardenId).ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}

