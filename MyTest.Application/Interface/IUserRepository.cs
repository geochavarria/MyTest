using MyTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTest.Application.Interface
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<bool> IsUnique(string firstName);
    }
}
