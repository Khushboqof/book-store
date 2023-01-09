using AutoMapper;
using BookStore.Data.DbContexts;
using BookStore.Data.IRepositories;
using BookStore.Data.Repositories;
using BookStore.Domain.Entities.Users;
using BookStore.Service.DTOs;
using BookStore.Service.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.services
{
    public class UserService : IUserService
    {
        public IUserRepository userRepository_;
        public AppDbContext AppDbContextappDbContext;
        public IMapper mappermapper_;

        public UserService()
        {
            var dbContext = new AppDbContext();
            userRepository_ = new UserRepository();
        }


        public async Task<bool> CreateAsync(UserForCreationDto userFor)
        {
            var newUser = await userRepository_.GetAsync(o => o.FirstName == userFor.FirstName);

            if (newUser is not null)
                throw new Exception("User already exist");

            var user = (User)userFor;

            await userRepository_.CreateAsync(user);

            return true;
        }

        public async Task<bool> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            var user = await userRepository_.GetAsync(expression);

            if (user is null)
                throw new Exception("User not found");

            userRepository_.DeleteAsync(expression);

            return true;
        }

        public async Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> expression = null!)
            => userRepository_.GetAllAsync(expression);

        public async Task<User> GetAsync(Expression<Func<User, bool>> expression = null!)
        {
             var user = await userRepository_.GetAsync(expression);

            if (user is null)
                throw new Exception("User not exist");

            return user;
        }

        public async Task<bool> UpdateAsync(int id, UserForUpdateDto userFor)
        {
            var user = await userRepository_.GetAsync(o => o.Id == id);

            if (user.FirstName is not null)
                user.FirstName = userFor.FirstName;

            if (user.LastName is not null)
                user.LastName = userFor.LastName;

            if (user.PhoneNumber is not null)
                user.PhoneNumber = userFor.PhoneNumber;

            userRepository_.UpdateAsync(user);

            return true;
        }
    }
}
 