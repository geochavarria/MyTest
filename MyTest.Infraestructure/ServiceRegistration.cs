using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyTest.Application.Interface;
using MyTest.Infraestructure.Context;
using MyTest.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTest.Infraestructure
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemory"))
            {
                serviceCollection.AddDbContext<LibraryDbContext>(options =>
                options.UseInMemoryDatabase("LibraryDB"));
            }

            serviceCollection.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            serviceCollection.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
