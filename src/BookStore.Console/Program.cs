

using BookStore.Data.DbContexts;
using BookStore.Data.IRepositories;
using BookStore.Data.Repositories;
using BookStore.Domain.Entities.Users;
using BookStore.Service.DTOs;
using BookStore.Service.Interfaces.Users;
using BookStore.Service.services;

var dbContext = new AppDbContext();

IGenericRepository<User> repository = new GenericRepository<User>(dbContext);

UserForUpdateDto user = new UserForUpdateDto()
{
    FirstName = "Johmn",
    LastName = "Doee",
    PhoneNumber = "912344223",
};

//var res = await repository.GetAsync(o => o.FirstName == "John");

IUserService service = new UserService();

 var res = await service.GetAllAsync(o => o.UserRole == 0);

foreach (var i in res)
{
    Console.WriteLine(i.FirstName);
}


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