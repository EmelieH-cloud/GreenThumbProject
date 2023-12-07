using GreenThumbProject.Models;

namespace GreenThumbProject.Data
{
    public class GardenRepository<T> where T : class
    {
        private readonly MyDBContext _context;

        public GardenRepository(MyDBContext context)
        {
            _context = context;
        }

        public Garden? GetGardenByUserId(int enteredUserId)
        {
            return _context.Set<T>()
                .OfType<Garden>()
                .FirstOrDefault(g => g.UserId == enteredUserId);
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
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