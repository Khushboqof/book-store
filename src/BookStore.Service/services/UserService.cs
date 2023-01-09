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
        public Task<bool> CreateAsync(UserForCreationDto userFor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Expression<Func<User, bool>> expression = null!)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> expression = null!)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(Expression<Func<User, bool>> expression = null!)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, UserForCreationDto userFor)
        {
            throw new NotImplementedException();
        }
    }
}
 