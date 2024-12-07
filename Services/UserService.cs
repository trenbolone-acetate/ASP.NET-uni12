using ASPNET12.Data;
using ASPNET12.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASPNET12.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> ReadUserByFName(string firstName)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.FirstName == firstName);
        }
        public async Task<List<User>> ReadUsersAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        // public async Task UpdateUserAsync(User user)
        // {
        //     _context.Entry(user).State = EntityState.Modified;
        //     await _context.SaveChangesAsync();
        // }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}