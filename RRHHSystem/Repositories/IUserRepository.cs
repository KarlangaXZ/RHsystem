using System.Threading.Tasks;
using RRHHSystem.Models;

namespace RRHHSystem.Repositories  
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task AddUserAsync(User user);
        Task<int> GetUserCountAsync();
    }
}