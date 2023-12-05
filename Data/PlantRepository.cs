using GreenThumbProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace GreenThumbProject.Data
{
    public class PlantRepository<T> where T : class
    {
        private readonly MyDBContext _context;
        private readonly DbSet<T> _dbSet;

        public PlantRepository(MyDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        // PlantNameIsTakenAsync
        // Returnerar true om namnet är upptaget, false om det är ledigt. 
        public async Task<Boolean> PlantNameIsTakenAsync(string enteredPlant)
        {

            var plant =
            await _dbSet.OfType<Plant>().SingleOrDefaultAsync(p => p.PlantName.ToLower() == enteredPlant.ToLower());

            if (plant != null)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // SearchPlantsAsync
        // Metod som undersöker om det sökta namnet motsvarar en plant i databasen. 
        public async Task<Plant?> SearchPlantAsync(string enteredPlant)
        {
            try
            {
                var plant =
                await _dbSet.OfType<Plant>().SingleOrDefaultAsync(p => p.PlantName.ToLower() == enteredPlant.ToLower());

                if (plant != null)
                {
                    return plant;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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