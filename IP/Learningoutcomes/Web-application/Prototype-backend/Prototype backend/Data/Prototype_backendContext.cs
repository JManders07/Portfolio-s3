using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prototype_backend.Models;

namespace Prototype_backend.Data
{
    public class Prototype_backendContext : DbContext
    {
        public Prototype_backendContext (DbContextOptions<Prototype_backendContext> options)
            : base(options)
        {
        }

        public DbSet<Prototype_backend.Models.Beer> Beer { get; set; } = default!;
    }
}
