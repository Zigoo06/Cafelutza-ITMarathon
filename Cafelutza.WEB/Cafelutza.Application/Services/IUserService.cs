using Cafelutza.Data.Models;

namespace Cafelutza.Application.Services;

public interface IUserService
{
    public Task AddUser(User user);
    public User GetUser(string name);
    public string GetUserRole(string userName);
}
