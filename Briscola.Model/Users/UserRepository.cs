namespace Briscola.Model;

public class UserRepository
{
    private readonly ICollection<User> _users;

    public UserRepository()
    {
        //TODO
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _users;
    }

    public User? GetUser(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }

    public void CreateUser(string name, string passHash)
    {
        var id = _users.Max(s => s.Id) + 1;

        var user = new User(
            id: id,
            name: name,
            passHash: passHash,
            elo: 1500);

        _users.Add(user);
    }

    public void UpdateUser(int id, string newName)
    {
        var userToUpdate = _users.FirstOrDefault(user => user.Id == id);

        if (userToUpdate is null)
        {
            throw new Exception("User was not found");
        }

        var updatedUser = new User(
            id: userToUpdate.Id,
            name: newName,
            passHash: userToUpdate.passHash,
            elo: userToUpdate.Elo);

        _ = _users.Remove(userToUpdate);

        _users.Add(updatedUser);
    }

    public void DeleteUser(int id)
    {
        var userToDelete = _users.FirstOrDefault(user => user.Id == id);

        if (userToDelete is null)
        {
            throw new Exception("User was not found");
        }

        _ = _users.Remove(userToDelete);
    }
}
