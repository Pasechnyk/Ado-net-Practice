using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using BookShop.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookShop.DatabaseData
{
    internal class BookShopDbContext : DbContext
    {
        public BookShopDbContext()
        {
            // delete if exist
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // configurate and seed entities
            modelBuilder.Entity<Author>().HasKey(x => x.Id);
            modelBuilder.Entity<Author>().Property(x => x.Name)
                                            .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Author>().Property(x => x.Surname)
                                            .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Author>().HasData(new[]
            {
                new Author() { Id = 1, Name = "Stephen", Surname = "King"},
                new Author() { Id = 2, Name = "Agatha", Surname = "Christie"},
                new Author() { Id = 3, Name = "Henric", Surname = "Middle"},
                new Author() { Id = 4, Name = "Jenna", Surname = "Taylor"},
                new Author() { Id = 5, Name = "Matthew", Surname = "Smith"}
            });

            modelBuilder.Entity<Genre>().HasKey(x => x.Id);
            modelBuilder.Entity<Genre>().Property(x => x.Name)
                                            .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() { Id = 1, Name = "Adventure"},
                new Genre() { Id = 2, Name = "Comedy"},
                new Genre() { Id = 3, Name = "Detective"},
                new Genre() { Id = 4, Name = "Documentary"},
                new Genre() { Id = 5, Name = "Drama"}
            });

            modelBuilder.Entity<Publisher>().HasKey(x => x.Id);
            modelBuilder.Entity<Publisher>().Property(x => x.Name)
                                            .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Publisher>().HasData(new[]
            {
                new Publisher() { Id = 1, Name = "Penguin Random House"},
                new Publisher() { Id = 2, Name = "Macmillan"},
                new Publisher() { Id = 3, Name = "Simon & Schuster"}
            });

            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Login)
                                            .HasMaxLength(50)
                                            .IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Password)
                                            .HasMaxLength(50)
                                            .IsRequired();
            modelBuilder.Entity<User>().HasData(new[]
            {
                new User() { Id = 1, Login = "Anastasia", Password = "0000"}
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
