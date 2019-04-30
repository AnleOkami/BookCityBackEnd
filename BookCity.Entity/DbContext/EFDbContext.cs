using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace EntityFramework
{
    public class EFDbContext:DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options):base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Personnels>().HasKey(b => b.Id).HasName("PrimaryKey_Id");
        }
        public DbSet<Personnels> CF_Personnel { get; set; }
    }
}
