

using BookStore.Data.DbContexts;
using BookStore.Data.IRepositories;
using BookStore.Data.Repositories;
using BookStore.Domain.Entities.Users;
using BookStore.Service.Interfaces.Users;
using BookStore.Service.services;

var dbContext = new AppDbContext();

IGenericRepository<User> repository = new GenericRepository<User>(dbContext);

User user = new User()
{
    CreatedAt = DateTime.UtcNow,
    FirstName = "Thompson",
    LastName = "Angel",
    PhoneNumber = "1234567890",
    Password = "1234",
    UserRole = BookStore.Domain.Enums.UserRole.Admin
};

//var res = await repository.GetAsync(o => o.FirstName == "John");

IUserService service = new UserService();


//var res = repository.GetAllAsync(o => o.Id == 1);

//foreach(var item in res)
//{
//    Console.WriteLine(item.UserRole);
//}

//await repository.CreateAsync(user);

//foreach (var i in repository.GetAllAsync(o => o.Id > 2))
//{
//    Console.WriteLine($"{i.Id}: {i.FirstName}: {i.LastName}");
//}