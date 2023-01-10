using AutoMapper;
using BookStore.Data.DbContexts;
using BookStore.Data.IRepositories;
using BookStore.Data.Repositories;
using BookStore.Domain.Entities.Users;
using BookStore.Service.DTOs;
using BookStore.Service.Interfaces.Users;
using System.Linq.Expressions;

namespace BookStore.Service.services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository_;
        private readonly AppDbContext AppDbContextappDbContext;
        private readonly IMapper mappermapper_;

        public UserService()
        {
            var dbContext = new AppDbContext();
            userRepository_ = new UserRepository(dbContext);
        }

        public async Task<bool> CreateAsync(UserForCreationDto userFor)
        {
            var newUser = await userRepository_.GetAsync(o => o.FirstName == userFor.FirstName);

            if (newUser is not null)
                throw new Exception("User already exist");

            var user = (User)userFor;

            user.CreatedAt = DateTime.UtcNow;

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

            user.UpdatedAt = DateTime.UtcNow;

            userRepository_.UpdateAsync(user);

            return true;
        }
    }
}
 