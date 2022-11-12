using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst
{
    public class CodeFirstDBContext : DbContext
    {
        public DbSet<Role> role { get; set; }
        public DbSet<Pengguna> pengguna { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=postgres;Port=5432;Database=FruitTest123;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasData(
                    new Role
                    {
                        Id = 1,
                        Name = "Pembeli"
                    },
                    new Role
                    {
                        Id = 2,
                        Name = "Penjual"
                    }
                );

            modelBuilder.Entity<Pengguna>()
                .HasData(
                    new Pengguna
                    {
                        Id= 1,
                        Username = "user1",
                        Password = "pass1",
                        Email = "user1@gmail.com",
                        RoleId = 1
                    },
                    new Pengguna
                    {
                        Id = 2,
                        Username = "user2",
                        Password = "pass2",
                        Email = "user2@gmail.com",
                        RoleId = 1
                    },
                    new Pengguna
                    {
                        Id = 3,
                        Username = "user3",
                        Password = "pass3",
                        Email = "user3@gmail.com",
                        RoleId = 2
                    }
                );
        }
    }
}
