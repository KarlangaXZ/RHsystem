using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using RRHHSystem.Models;
using RRHHSystem.Data; 

namespace RRHHSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext; 

        public UserRepository(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> GetUserCountAsync()
        {
            return await _dbContext.Users.CountAsync();
        }
    }
}
