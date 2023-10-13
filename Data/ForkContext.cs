using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gurdeep_Fork_Assignment.Models;

namespace Gurdeep_Fork_Assignment.Data
{
    public class ForkContext : DbContext
    {
        public ForkContext(DbContextOptions<ForkContext> options)
            : base(options)
        {
        }

        public DbSet<Fork> Fork { get; set; }
    }
}
