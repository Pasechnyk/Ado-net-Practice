using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopAdministration.Entities;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ShopAdministration.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // configurate entities
            modelBuilder.Entity<Category>().HasKey(x => x.Id);
            modelBuilder.Entity<Category>().Property(x => x.Name)
                                            .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Category>().ToTable("Products");
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Grocery"},
                new Category() { Id = 2, Name = "Dairy"},
                new Category() { Id = 3, Name = "Meat Products"},
            });

            modelBuilder.Entity<Country>().HasKey(x => x.Id);
            modelBuilder.Entity<Country>().Property(x => x.Name)
                                            .HasMaxLength(20)
                                            .IsRequired();
            // seed
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Australia"},
                new Country() { Id = 2, Name = "Ausrtia"},
                new Country() { Id = 3, Name = "Belgium"},
                new Country() { Id = 4, Name = "Canada"},
                new Country() { Id = 5, Name = "Germany"},
                new Country() { Id = 6, Name = "Poland"},
                new Country() { Id = 7, Name = "Spain"},
                new Country() { Id = 8, Name = "Ukraine"},
            });

            modelBuilder.Entity<City>().HasKey(x => x.Id);
            modelBuilder.Entity<City>().Property(x => x.Name)
                                           .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<City>().Property(x => x.CountryId).IsRequired();
            // seed
            modelBuilder.Entity<City>().HasData(new[]
            {
                new City() { Id = 1, Name = "Canberra", CountryId = 1},
                new City() { Id = 2, Name = "Vienna", CountryId = 2},
                new City() { Id = 3, Name = "Brussels", CountryId = 3},
                new City() { Id = 4, Name = "Toronto", CountryId = 4},
                new City() { Id = 5, Name = "Berlin", CountryId = 5},
                new City() { Id = 6, Name = "Warsaw", CountryId = 6},
                new City() { Id = 7, Name = "Madrid", CountryId = 7},
                new City() { Id = 8, Name = "Kyiv", CountryId = 8}
            });

            modelBuilder.Entity<Position>().HasKey(x => x.Id);
            modelBuilder.Entity<Position>().Property(x => x.Name)
                                           .HasMaxLength(20)
                                            .IsRequired();
            // seed
            modelBuilder.Entity<Position>().HasData(new[]
            {
                new Position() { Id = 1, Name = "Administrator"},
                new Position() { Id = 2, Name = "Cashier"},
                new Position() { Id = 3, Name = "Cleaner"}
            });

            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().Property(x => x.Name)
                                           .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Price).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Discount).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.CategoryId).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.Quantity).IsRequired();
            modelBuilder.Entity<Product>().Property(x => x.IsInStock).IsRequired();
            // seed
            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product()
                {
                    Id = 1,
                    Name = "Cheese",
                    Price = (decimal)12,
                    Discount = 5,
                    CategoryId = 2,
                    Quantity = 38,
                    IsInStock = true
                },
                new Product()
                {
                    Id = 2,
                    Name = "Cucumber",
                    Price = (decimal)10,
                    Discount = 2,
                    CategoryId = 1,
                    Quantity = 120,
                    IsInStock = true
                },
                new Product()
                {
                    Id = 3,
                    Name = "Ham",
                    Price = (decimal)22,
                    Discount = 10,
                    CategoryId = 3,
                    Quantity = 8,
                    IsInStock = true
                }
            });

            modelBuilder.Entity<Shop>().HasKey(x => x.Id);
            modelBuilder.Entity<Shop>().HasKey(x => x.Name);
            modelBuilder.Entity<Shop>().Property(x => x.Name)
                                           .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Shop>().Property(x => x.Address).IsRequired();
            modelBuilder.Entity<Shop>().Property(x => x.CityId).IsRequired();
            modelBuilder.Entity<Shop>().Property(x => x.ParkingArea).IsRequired();
            // seed
            modelBuilder.Entity<Shop>().HasData(new[]
            {
                new Shop()
                {
                    Id = 1,
                    Name = "Trash",
                    Address = "Schuhevycha St",
                    CityId = 1,
                    ParkingArea = 1
                }
            });

            modelBuilder.Entity<Worker>().HasKey(x => x.Id);
            modelBuilder.Entity<Worker>().HasKey(x => x.Name);
            modelBuilder.Entity<Worker>().Property(x => x.Name)
                                           .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Worker>().Property(x => x.Surname)
                                           .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Worker>().Property(x => x.Salary).IsRequired();
            modelBuilder.Entity<Worker>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<Worker>().Property(x => x.PhoneNumber).IsRequired();
            modelBuilder.Entity<Worker>().Property(x => x.PositionId).IsRequired();
            modelBuilder.Entity<Worker>().Property(x => x.ShopId).IsRequired();
            // seed
            modelBuilder.Entity<Worker>().HasData(new[]
            {
                new Worker()
                {
                    Id = 1,
                    Name = "Oleg",
                    Surname = "Koval",
                    Email = "mfvnfkn@gmail.com",
                    PhoneNumber = "Myr Avenue",
                    PositionId = 1,
                    ShopId = 1
                }
            });

            // provide relations
            modelBuilder.Entity<City>().HasOne(x => x.Country).WithMany(x => x.Cities).HasForeignKey(x => x.CountryId);
            modelBuilder.Entity<City>().HasMany(x => x.Shops).WithOne(x => x.City).HasForeignKey(x => x.CityId);
            modelBuilder.Entity<Shop>().HasMany(x => x.Products).WithMany(x => x.Shops);
            modelBuilder.Entity<Shop>().HasMany(x => x.Workers).WithOne(x => x.Shop).HasForeignKey(x => x.ShopId);
            modelBuilder.Entity<Product>().HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<Worker>().HasOne(x => x.Position).WithMany(x => x.Workers).HasForeignKey(x => x.PositionId);


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopAdministration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
