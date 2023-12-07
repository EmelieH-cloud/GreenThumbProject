using GreenThumbProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace GreenThumbProject.Data
{
    public class PlantRepository<T> where T : class
    {
        private readonly MyDBContext _context;

        public PlantRepository(MyDBContext context)
        {
            _context = context;
        }

        public async Task<Boolean> PlantNameIsTakenAsync(string enteredPlant)
        {
            var plant = await _context.Set<T>().OfType<Plant>().SingleOrDefaultAsync(p => p.PlantName.ToLower() == enteredPlant.ToLower());

            return plant != null;
        }

        public async Task<Plant?> SearchPlantAsync(string enteredPlant)
        {
            try
            {
                var plant = await _context.Set<T>().OfType<Plant>().FirstOrDefaultAsync(p => p.PlantName.ToLower() == enteredPlant.ToLower());

                return plant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public async Task<Plant?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().OfType<Plant>().FirstOrDefaultAsync(plant => plant.PlantId == id);
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