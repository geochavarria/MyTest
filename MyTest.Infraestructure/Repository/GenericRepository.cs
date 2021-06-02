using MyTest.Application.Interface;
using MyTest.Infraestructure.Context;
using System;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTest.Infraestructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly LibraryDbContext _dbContext;

        public GenericRepository(LibraryDbContext _db)
        {
            _dbContext = _db;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;

        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
