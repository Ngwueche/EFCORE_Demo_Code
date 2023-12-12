using EFCORE_Demo_Code.Data;
using EFCORE_Demo_Code.Data.Entities;
using EFCORE_Demo_Code.Services;

Console.WriteLine("Hello, Class");

var ctx = new ApplicationDbContext();
UserService userService = new UserService(ctx);

Console.WriteLine("Enter your Name");
var name = Console.ReadLine();
Console.WriteLine("Enter your Email");
var email = Console.ReadLine();
Console.WriteLine("Enter your password");
var password = Console.ReadLine();

var user = new AppUser
{
    Id = Guid.NewGuid().ToString(),
    Name = name,
    Email = email,
    Password = password,
    ConfirmPassword = true
};

var addUserResult = userService.CreateUser(user);
if (addUserResult > 0)
    Console.WriteLine($"New user added: {user.Id}");
Console.WriteLine("Error");
