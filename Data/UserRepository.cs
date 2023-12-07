using GreenThumbProject.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<User?> AuthenticateCredentialsAsync(string enteredUsername, string enteredPassword)
        {
            try
            {
                var user = await _context.Users
                    .SingleOrDefaultAsync(u => u.UserName == enteredUsername && u.Password == enteredPassword);

                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<bool> UserNameIsAvailableAsync(string requestedUsername)
        {
            var user = await _context.Users
                .SingleOrDefaultAsync(u => u.UserName == requestedUsername);

            return user == null;
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
