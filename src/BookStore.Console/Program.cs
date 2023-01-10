

using BookStore.Data.DbContexts;
using BookStore.Data.IRepositories;
using BookStore.Data.Repositories;
using BookStore.Domain.Entities.Users;
using BookStore.Service.DTOs;
using BookStore.Service.Interfaces.Users;
using BookStore.Service.services;

var dbContext = new AppDbContext();

UserForUpdateDto user = new UserForUpdateDto()
{
    FirstName = "Kimdur",
    LastName = "nimadureyev",
    PhoneNumber = "993455345",
};

UserForCreationDto user1 = new UserForCreationDto()
{
    FirstName = "Salom",
    LastName = "Toqayev",
    PhoneNumber = "912344223",
};

//var res = await repository.GetAsync(o => o.FirstName == "John");

IUserService service = new UserService();

await service.UpdateAsync(7, user);

//var res = await service.GetAllAsync(o => o.PhoneNumber.StartsWith("99"));

//foreach (var i in res)
//{
//    Console.WriteLine(i.FirstName);
//}


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