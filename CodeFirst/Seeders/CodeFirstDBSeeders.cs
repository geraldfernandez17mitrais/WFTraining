using CodeFirst.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CodeFirst.Seeders
{
    public class CodeFirstDBSeeders
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {
                CodeFirstDBContext context = servicescope.ServiceProvider.GetService<CodeFirstDBContext>();
                context.Database.Migrate();

                // Role
                if (!context.role.Any())
                {
                    context.role.AddRange(new List<Role>()
                    {
                        new Role()
                        {
                            Name = "Pembeli"
                        },
                        new Role()
                        {
                            Name = "Penjual"
                        }
                    });
                }

                // Pengguna
                if (!context.pengguna.Any())
                {
                    context.pengguna.AddRange(new List<Pengguna>()
                    {
                        new Pengguna()
                        {
                            Username = "user1",
                            Password = "pass1",
                            Email = "user1@gmail.com"
                        },
                        new Pengguna()
                        {
                            Username = "user2",
                            Password = "pass2",
                            Email = "user2@gmail.com"
                        }
                    });
                }
            }
        }
    }
}
