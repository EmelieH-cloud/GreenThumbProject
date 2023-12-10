using GreenThumbProject.Models;
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

        public bool PlantNameIsTaken(string enteredPlant)
        {
            var plant = _context.Set<T>().OfType<Plant>().SingleOrDefault(p => p.PlantName.ToLower() == enteredPlant.ToLower());
            return plant != null;
        }


        public Plant? SearchPlant(string enteredPlant)
        {
            try
            {
                var plant = _context.Set<T>().OfType<Plant>().FirstOrDefault(p => p.PlantName.ToLower() == enteredPlant.ToLower());
                return plant;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Plant> GetPlantsMatchingString(string searchString)
        {
            return _context.Plants
                .Where(p => p.PlantName.Contains(searchString))
                .ToList();
        }

        public Plant? GetById(int id)
        {
            return _context.Set<T>().OfType<Plant>().FirstOrDefault(plant => plant.PlantId == id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entityToDelete = _context.Set<T>().Find(id);

            if (entityToDelete != null)
            {
                _context.Set<T>().Remove(entityToDelete);
                _context.SaveChanges();
            }
        }
    }
}