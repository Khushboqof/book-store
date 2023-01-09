using BookStore.Domain.Entities.Users;
using BookStore.Service.DTOs;
using System.Linq.Expressions;

namespace BookStore.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<bool> CreateAsync(UserForCreationDto userFor);
        Task<bool> UpdateAsync(int id, UserForCreationDto userFor);
        Task<bool> DeleteAsync(Expression<Func<User, bool>> expression = null!);
        Task<User> GetAsync(Expression<Func<User, bool>> expression = null!);
        Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> expression = null!);
    }
}