using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookify.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure
{
    public sealed class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions opts) : base(opts)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}