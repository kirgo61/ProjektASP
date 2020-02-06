using System.Linq;
using Xunit;
using ProjektASP.Controllers;
using Moq;
using System.Threading.Tasks;
using ProjektASP.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ProjektASPTest
{
    public class UnitTest1
    {
        //private DbContext CreateDbContext()
        //{
        //    var opt = new DbContextOptionsBuilder<PersonContext>().UseInMemoryDatabase(Guid.NewGuid().ToString("N")).Options;
        //    var dbContext = new PersonContext(opt);
        //    return dbContext;
        //}
        //[Fact]
        //public async Task Person_Contains_All_Persons()
        //{
        //    var dbContext = CreateDbContext();
        //    var sut = new PeopleController(dbContext);
            //var serviceProvider = new ServiceCollection().AddEntityFrameworkSqlServer().BuildServiceProvider();
            //var builder = new DbContextOptionsBuilder<PersonContext>();
            //builder.UseSqlServer($"Server = (localdb)\\mssqllocaldb; Database = PersonDB; Trusted_Connection = True; MultipleActiveResultSets = True").UseInternalServiceProvider(serviceProvider);
            //var context = new PersonContext(builder.Options);
            //context.Database.Migrate();
            //context.Persons.Add(new Person { FullName = "DamianH", City = "Krk", ZipCode = 12345, PersonID = 1, Position = "WebDev" });
            //context.SaveChanges();
            //PeopleController query = new PeopleController(context);
            //var peopls = query.Execute();
            //Assert.Equal(1, peopls.Count());
            //var per = peopls.First();
            //Assert.Equal("sdasd", per.FullName);
            // var per = new List<Person>
            //{
            //    new Person {PersonID=1,FullName="DamianH",ZipCode=12334, City="krk", Position="WebDev"}
            //};

            // var builder = new DbContextOptionsBuilder<PersonContext>().EnableSensitiveDataLogging().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PersonDB;Trusted_Connection=True;MultipleActiveResultSets=True");
            // using (var context = new PersonContext(builder.Options))
            // {
            //     context.Database.OpenConnection();
            //     context.Database.EnsureCreated();
            //     context.Persons.Add(new Person { FullName = "DamianH", City = "Krk", ZipCode = 12345, PersonID = 1, Position = "Webdev" });
            //     context.SaveChanges();
            //     Assert.Equal(1, context.Persons.Count(p => p.FullName == "DamianH"));
            // }
            //var mockSet = new Mock<DbSet<Person>>(per);
            //var mockContext = new Mock<PersonContext>();
            //mockContext.Setup(m => m.Persons).Returns(mockSet.Object);

            //var service = new PeopleController(mockContext.Object);
            //var people = await service.Index(null);
            

           
        }
    }
}
