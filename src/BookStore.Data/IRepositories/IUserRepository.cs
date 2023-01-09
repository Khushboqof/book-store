using BookStore.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
