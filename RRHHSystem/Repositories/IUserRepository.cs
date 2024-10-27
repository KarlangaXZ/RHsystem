using System.Threading.Tasks;
using RRHHSystem.Models;

namespace RRHHSystem.Repositories  // Asegúrate de que el espacio de nombres sea correcto
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task AddUserAsync(User user);
        Task<int> GetUserCountAsync();
    }
}