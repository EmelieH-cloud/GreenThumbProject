using GreenThumbProject.Models;
using System.Windows;

namespace GreenThumbProject.Data
{
    public class UserRepository<T> where T : class
    {
        private readonly MyDBContext _context;

        public UserRepository(MyDBContext context)
        {
            _context = context;
        }

        public User? AuthenticateCredentials(string enteredUsername, string enteredPassword)
        {
            try
            {
                var user = _context.Users
                    .SingleOrDefault(u => u.UserName == enteredUsername && u.Password == enteredPassword);

                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool UserNameIsAvailable(string requestedUsername)
        {
            var user = _context.Users
                .SingleOrDefault(u => u.UserName == requestedUsername);

            return user == null;
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
