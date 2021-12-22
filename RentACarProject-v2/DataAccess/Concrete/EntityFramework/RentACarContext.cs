using Entities.Concrete;
using Microsoft.EntityFrameworkCore;  // DbContext'den miras alabilmek için ekliyoruz. NuGet'den DataAccess içine Entity Framework indirdik.
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DOF2PHV; Database=RentACarDb; Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
