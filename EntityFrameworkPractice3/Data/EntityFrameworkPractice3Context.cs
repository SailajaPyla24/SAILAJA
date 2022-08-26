using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkPractice3.Models;

namespace EntityFrameworkPractice3.Data
{
    public class EntityFrameworkPractice3Context : DbContext
    {
        public EntityFrameworkPractice3Context (DbContextOptions<EntityFrameworkPractice3Context> options)
            : base(options)
        {
        }

        public DbSet<EntityFrameworkPractice3.Models.Department> Department { get; set; } = default!;
    }
}
