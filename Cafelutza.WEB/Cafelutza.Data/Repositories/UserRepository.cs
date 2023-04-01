using Cafelutza.Data.Models;

namespace Cafelutza.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DatabaseContext _dbContext;
    public UserRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddUser(User user)
    {
        var response = _dbContext.Users.FirstOrDefault(x=> x.Id == user.Id);
        if (response == null)
        {
            _dbContext.Users.Add(user);
        }
        else
        {
            response.Name = user.Name;
            response.Email = user.Email;
            response.Role = user.Role;
        }
        await _dbContext.SaveChangesAsync();
    }

    public User GetUser(string name)
    {
        var response = _dbContext.Users.FirstOrDefault(x => x.Name == name);
        return response;
    }
}
