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
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // configurate and seed entities

            modelBuilder.Entity<Author>().HasKey(x => x.Id);
            modelBuilder.Entity<Author>().Property(x => x.Name)
                                            .HasMaxLength(100)
                                            .IsRequired();
            modelBuilder.Entity<Author>().Property(x => x.Surname)
                                            .HasMaxLength(100)
                                            .IsRequired();
            modelBuilder.Entity<Author>().HasData(new[]
            {
                new Author() { Id = 1, Name = "Stephen", Surname = "King"},
                new Author() { Id = 2, Name = "Agatha", Surname = "Christie"},
                new Author() { Id = 3, Name = "Henric", Surname = "Middle"},
                new Author() { Id = 4, Name = "Jenna", Surname = "Taylor"},
                new Author() { Id = 5, Name = "Matthew", Surname = "Smith"},
                new Author() { Id = 6, Name = "Vanessa", Surname = "Mint"},
                new Author() { Id = 7, Name = "George", Surname = "Print"},
                new Author() { Id = 8, Name = "Nicolas", Surname = "Thick"},
                new Author() { Id = 9, Name = "Momo", Surname = "Mimi"},
                new Author() { Id = 10, Name = "Josuke", Surname = "Jos"}
            });

            modelBuilder.Entity<Book>().HasKey(x => x.Id);
            modelBuilder.Entity<Book>().Property(x => x.Title)
                                            .HasMaxLength(100)
                                            .IsRequired();
            modelBuilder.Entity<Book>().Property(x => x.AuthorId).IsRequired();
            modelBuilder.Entity<Book>().Property(x => x.Year).IsRequired();
            modelBuilder.Entity<Book>().Property(x => x.PagesCount).IsRequired();
            modelBuilder.Entity<Book>().Property(x => x.GenreId).IsRequired();
            modelBuilder.Entity<Book>().Property(x => x.Price).IsRequired();
            modelBuilder.Entity<Book>().Property(x => x.PublisherId).IsRequired();
            modelBuilder.Entity<Book>().HasData(new[]
            {
                new Book()
                {
                    Id = 1,
                    Title = "It",
                    AuthorId = 1,
                    Year = 1985,
                    PagesCount = 850,
                    GenreId = 2,
                    Price = 20,
                    PublisherId = 1
                },
                new Book()
                {
                    Id = 2,
                    Title = "Puarot",
                    AuthorId = 2,
                    Year = 1987,
                    PagesCount = 240,
                    GenreId = 3,
                    Price = 18,
                    PublisherId = 2
                },
                new Book()
                {
                    Id = 3,
                    Title = "Wolf in the Dark",
                    AuthorId = 3,
                    Year = 2000,
                    PagesCount = 315,
                    GenreId = 4,
                    Price = 12,
                    PublisherId = 3
                },
                new Book()
                {
                    Id = 4,
                    Title = "Beans in the Soup",
                    AuthorId = 6,
                    Year = 2004,
                    PagesCount = 378,
                    GenreId = 5,
                    Price = 23,
                    PublisherId = 1
                },
                new Book()
                {
                    Id = 5,
                    Title = "Queens and Kings",
                    AuthorId = 4,
                    Year = 1999,
                    PagesCount = 293,
                    GenreId = 4,
                    Price = 11,
                    PublisherId = 2
                },
                new Book()
                {
                    Id = 6,
                    Title = "Adventures of Simon and His Friends",
                    AuthorId = 8,
                    Year = 2010,
                    PagesCount = 280,
                    GenreId = 1,
                    Price = 25,
                    PublisherId = 3
                },
                new Book()
                {
                    Id = 7,
                    Title = "Winds and Clouds",
                    AuthorId = 9,
                    Year = 2011,
                    PagesCount = 277,
                    GenreId = 3,
                    Price = 31,
                    PublisherId = 1
                },
                new Book()
                {
                    Id = 8,
                    Title = "Always There",
                    AuthorId = 7,
                    Year = 2013,
                    PagesCount = 402,
                    GenreId = 5,
                    Price = 24,
                    PublisherId = 2
                },
                new Book()
                {
                    Id = 9,
                    Title = "Do Not Cross The Road",
                    AuthorId = 10,
                    Year = 2017,
                    PagesCount = 516,
                    GenreId = 6,
                    Price = 29,
                    PublisherId = 3
                },
                new Book()
                {
                    Id = 10,
                    Title = "Beeps and Bops",
                    AuthorId = 5,
                    Year = 2002,
                    PagesCount = 264,
                    GenreId = 3,
                    Price = 30,
                    PublisherId = 2
                }
            });

            modelBuilder.Entity<Genre>().HasKey(x => x.Id);
            modelBuilder.Entity<Genre>().Property(x => x.Name)
                                            .HasMaxLength(100)
                                            .IsRequired();
            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() { Id = 1, Name = "Adventure"},
                new Genre() { Id = 2, Name = "Comedy"},
                new Genre() { Id = 3, Name = "Detective"},
                new Genre() { Id = 4, Name = "Documentary"},
                new Genre() { Id = 5, Name = "Drama"},
                new Genre() { Id = 6, Name = "Horror"}
            });

            modelBuilder.Entity<Publisher>().HasKey(x => x.Id);
            modelBuilder.Entity<Publisher>().Property(x => x.Name)
                                            .HasMaxLength(100)
                                            .IsRequired();
            modelBuilder.Entity<Publisher>().HasData(new[]
            {
                new Publisher() { Id = 1, Name = "Penguin Random House"},
                new Publisher() { Id = 2, Name = "Macmillan"},
                new Publisher() { Id = 3, Name = "Simon & Schuster"}
            });

            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Login)
                                            .HasMaxLength(100)
                                            .IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Password)
                                            .HasMaxLength(100)
                                            .IsRequired();
            modelBuilder.Entity<User>().HasData(new[]
            {
                new User() { Id = 1, Login = "Anastasia", Password = "0000"},
                new User() { Id = 2, Login = "Manager", Password = "1111"}
            });

            // provide relationships
            modelBuilder.Entity<Publisher>().HasMany(x => x.Books).WithOne(x => x.Publisher).HasForeignKey(x => x.PublisherId);
            modelBuilder.Entity<Author>().HasMany(x => x.Books).WithOne(x => x.Author).HasForeignKey(x => x.AuthorId);
            modelBuilder.Entity<Genre>().HasMany(x => x.Books).WithOne(x => x.Genre).HasForeignKey(x => x.GenreId);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
