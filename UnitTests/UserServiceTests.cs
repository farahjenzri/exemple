using exemple.Models;
using exemple.services;
using NUnit.Framework;

namespace UnitTests
{
    public class UserServiceTests
    {
        UserService userService;

        [SetUp]
        public void Setup()
        {
            userService = new UserService();
        }
        [Test]
        public void FilterUserByName_Works()
        {

            //Arrange
            var name = "Farah";
            var users = new List<User>() { new User { FisrtName = "Farah", LastName = "Jenzri" },
            new User { FisrtName = "test", LastName = "test" },
            new User { FisrtName = "test1", LastName = "test1" },
            new User { FisrtName = "oussama", LastName = "oussama" }};
            //Act
            var filteredUsers = userService.FilterUserByName(name, users);


            //Assert
            
                Assert.That(filteredUsers, Is.EqualTo(users.Where(x => x.FisrtName == name)));
              
           

        }
    }
}