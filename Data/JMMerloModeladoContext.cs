using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JMMerloModelado.Models;

namespace JMMerloModelado.Data
{
    public class JMMerloModeladoContext : DbContext
    {
        public JMMerloModeladoContext (DbContextOptions<JMMerloModeladoContext> options)
            : base(options)
        {
        }

        public DbSet<JMMerloModelado.Models.Product> Product { get; set; } = default!;
    }
}
