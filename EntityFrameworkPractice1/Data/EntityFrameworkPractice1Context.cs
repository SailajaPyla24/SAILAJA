using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkPractice1.Models;

namespace EntityFrameworkPractice1.Data
{
    public class EntityFrameworkPractice1Context : DbContext
    {
        public EntityFrameworkPractice1Context (DbContextOptions<EntityFrameworkPractice1Context> options)
            : base(options)
        {
        }

        public DbSet<EntityFrameworkPractice1.Models.Student> Student { get; set; } = default!;
    }
}
