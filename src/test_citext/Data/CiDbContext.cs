using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test_citext.Models;

namespace test_citext.Data
{
    public class CiDbContext: DbContext
    {
        public CiDbContext(DbContextOptions<CiDbContext> options): base(options)
        {

        }

        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasData(new[]
                {
                    new Profile {Id=-1, UserName = "Admin"}
                });
            });
        }
    }
}
