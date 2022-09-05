using exemple.Models;
namespace exemple.services
{
    public class UserService
    {
        public List<User> FilterUserByName(string Name, List<User> users)
        {
            var filteredUsers =users
                .Where(user=> user.FisrtName == Name)
                .ToList();
            return filteredUsers;
        }
    }
}
