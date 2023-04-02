using Cafelutza.Data.Models;
using Cafelutza.Data.Repositories;

namespace Cafelutza.Application.Services;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task AddUser(User user)
    {
        await _userRepository.AddUser(user);
    }

    public User GetUser(string name)
    {
       return _userRepository.GetUser(name);
    }

    public string GetUserRole(string userName)
    {
        return _userRepository.GetUserRole(userName);
    }
}
