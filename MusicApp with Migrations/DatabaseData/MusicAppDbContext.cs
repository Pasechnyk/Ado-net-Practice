using Microsoft.EntityFrameworkCore;
using MusicApp.Entities;
using Microsoft.EntityFrameworkCore.SqlServer;

// Music App Database source
namespace MusicApp
{
    internal class MusicAppDbContext : DbContext
    {
        public MusicAppDbContext()
        {
            // delete if exist
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Italy"},
                new Country() { Id = 3, Name = "France"},
                new Country() { Id = 4, Name = "Spain"},
                new Country() { Id = 5, Name = "USA"}
            });

            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() { Id = 1, Name = "Pop"},
                new Genre() { Id = 2, Name = "Rock-n-Roll"},
                new Genre() { Id = 3, Name = "Rock"},
                new Genre() { Id = 4, Name = "Alternative"},
                new Genre() { Id = 5, Name = "Beat"}
            });


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}