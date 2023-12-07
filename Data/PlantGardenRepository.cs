using GreenThumbProject.Models;

namespace GreenThumbProject.Data
{
    public class PlantGardenRepository<T> where T : class
    {
        private readonly MyDBContext _context;

        public PlantGardenRepository(MyDBContext context)
        {
            _context = context;
        }

        public List<PlantGarden> GetPlantGardenbyGardenId(int gardenId)
        {
            return _context.Set<T>().OfType<PlantGarden>().Where(pgarden => pgarden.GardenId == gardenId).ToList();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
    }
}

