using Microsoft.EntityFrameworkCore;
using MyTest.Application.Interface;
using MyTest.Domain.Models;
using MyTest.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTest.Infraestructure.Repository
{
 
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DbSet<User> Users;

        public UserRepository(LibraryDbContext _context) : base(_context)
        {
            Users = _context.Set<User>();
        }

        public async Task<bool> IsUnique(string firstName)
        {
            return true;
        }
    }
}
