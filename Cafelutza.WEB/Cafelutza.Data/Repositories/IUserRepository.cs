using Cafelutza.Data.Models;

namespace Cafelutza.Data.Repositories;
public interface IUserRepository
{
    public Task AddUser(User user);
    public User GetUser(string name);
}
