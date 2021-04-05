using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using BetterCalm.Domain.Entities;
using System.IO;


namespace BetterCalm.DataAccess.Context
{
    [ExcludeFromCodeCoverageAttribute]
    public class BetterCalmDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
      

        public BetterCalmDbContext(DbContextOptions<BetterCalmDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        
    }

}
