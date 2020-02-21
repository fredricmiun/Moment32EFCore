using Lab32.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab32.Data
{
    public class CdContext:DbContext
    {
        public CdContext(DbContextOptions<CdContext> options) : base(options)
        {

        }

        public DbSet<Cd> Cds { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}
