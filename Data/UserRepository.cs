using GreenThumbProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace GreenThumbProject.Data
{
    public class UserRepository<T> where T : class
    {
        private readonly MyDBContext _context;
        private readonly DbSet<T> _dbSet;

        public UserRepository(MyDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        // AuthenticateCredentials()
        // Metod som undersöker om givet användarnamn + lösen motsvaras av en user i databasen.
        public async Task<User?> AuthenticateCredentialsAsync(string enteredUsername, string enteredPassword)
        {
            try
            {
                var user =
                await _dbSet.OfType<User>().SingleOrDefaultAsync(u => u.UserName == enteredUsername && u.Password == enteredPassword);

                if (user != null)
                {
                    return user;
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