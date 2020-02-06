using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektASP.Models
{
    public class PersonContext:IdentityDbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options):base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
