using GreenThumbProject.Models;

namespace GreenThumbProject.Data
{
    public class InstructionRepository<T> where T : class
    {
        private readonly MyDBContext _context;

        public InstructionRepository(MyDBContext context)
        {
            _context = context;
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<Instruction> GetAll()
        {
            return _context.Set<T>().OfType<Instruction>().ToList();
        }

        public List<Instruction> GetAllPlantInstructions(int plantId)
        {
            return _context.Set<T>().OfType<Instruction>().Where(i => i.PlantId == plantId).ToList();
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