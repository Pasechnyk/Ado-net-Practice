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

            // update: entities configuration and data seed
            modelBuilder.Entity<Album>().HasKey(x => x.Id);
            modelBuilder.Entity<Album>().Property(x => x.Name)
                                            .HasMaxLength(30)
                                            .IsRequired();
            modelBuilder.Entity<Album>().HasData(new[]
            {
                new Album() { Id = 1, Name = "Sunshine", Year = 2021},
                new Album() { Id = 2, Name = "Bring Me The Peace", Year = 2022},
                new Album() { Id = 3, Name = "Joyfull Summer", Year = 2020}
            });

            modelBuilder.Entity<Country>().HasKey(x => x.Id);
            modelBuilder.Entity<Country>().Property(x => x.Name)
                                            .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Italy"},
                new Country() { Id = 3, Name = "France"},
                new Country() { Id = 4, Name = "Spain"},
                new Country() { Id = 5, Name = "USA"}
            });

            modelBuilder.Entity<Genre>().HasKey(x => x.Id);
            modelBuilder.Entity<Genre>().Property(x => x.Name)
                                            .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() { Id = 1, Name = "Pop"},
                new Genre() { Id = 2, Name = "Rock-n-Roll"},
                new Genre() { Id = 3, Name = "Rock"},
                new Genre() { Id = 4, Name = "Alternative"},
                new Genre() { Id = 5, Name = "Beat"}
            });

            modelBuilder.Entity<Singer>().HasKey(x => x.Id);
            modelBuilder.Entity<Singer>().Property(x => x.Name)
                                            .HasMaxLength(20)
                                            .IsRequired();
            modelBuilder.Entity<Singer>().HasData(new[]
            {
                new Singer() { Id = 1, Name = "Meddy"},
                new Singer() { Id = 2, Name = "Francis"},
                new Singer() { Id = 3, Name = "Maddison"}
            });

            // relationships
            modelBuilder.Entity<Album>().HasOne(x => x.Genre);
            modelBuilder.Entity<Country>().HasMany(x => x.Tracks);
            modelBuilder.Entity<Singer>().HasMany(x => x.Tracks).WithOne(x => x.Singer);
            modelBuilder.Entity<Track>().HasOne(x => x.Album).WithMany(x => x.Tracks);
            modelBuilder.Entity<PlayList>().HasMany(x => x.Tracks).WithOne(x => x.PlayList);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MusicApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}