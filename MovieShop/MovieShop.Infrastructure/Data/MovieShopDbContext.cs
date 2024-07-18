using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Entities;

namespace MovieShop.Infrastructure.Data;

public class MovieShopDbContext : DbContext
{
    public DbSet<Casts> Casts { get; set; }
    public DbSet<Genres> Genres { get; set; }
    public DbSet<Movies> Movies { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<Roles> Roles { get; set; }

    public DbSet<Favorites> Favorites { get; set; }
    public DbSet<MovieCasts> MovieCasts { get; set; }
    public DbSet<MovieGenres> MovieGenres { get; set; }
    public DbSet<Purchases> Purchases { get; set; }
    public DbSet<Reviews> Reviews { get; set; }
    public DbSet<Trailers> Trailers { get; set; }
    public DbSet<UserRoles> UserRoles { get; set; }

    public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Favorites>()
            .HasKey(f => new { f.MovieId, f.UserId });

        modelBuilder.Entity<Favorites>()
            .HasOne(f => f.Movies)
            .WithMany(m => m.FavoritesList)
            .HasForeignKey(f => f.MovieId);

        modelBuilder.Entity<Favorites>()
            .HasOne(f => f.Users)
            .WithMany(u => u.FavoritesList)
            .HasForeignKey(f => f.UserId);

        modelBuilder.Entity<MovieCasts>()
            .HasKey(mc => new { mc.MovieId, mc.CastId, mc.Character });
        modelBuilder.Entity<MovieCasts>()
            .HasOne(mc => mc.Movies)
            .WithMany(m => m.MovieCastsList)
            .HasForeignKey(mc => mc.MovieId);

        modelBuilder.Entity<MovieCasts>()
            .HasOne(mc => mc.Casts)
            .WithMany(c => c.MovieCastsList)
            .HasForeignKey(mc => mc.CastId);
        modelBuilder.Entity<MovieGenres>()
            .HasKey(mg => new { mg.MovieId, mg.GenreId });
        modelBuilder.Entity<MovieGenres>()
            .HasOne(mg => mg.Movies)
            .WithMany(m => m.MovieGenresList)
            .HasForeignKey(mg => mg.MovieId);
        modelBuilder.Entity<MovieGenres>()
            .HasOne(mg => mg.Genres)
            .WithMany(g => g.MovieGenresList)
            .HasForeignKey(mg => mg.GenreId);

        modelBuilder.Entity<Purchases>()
            .HasKey(p => new { p.MovieId, p.UserId });
        modelBuilder.Entity<Purchases>()
            .HasOne(p => p.Movies)
            .WithMany(p => p.PurchasesList)
            .HasForeignKey(p => p.MovieId);
        modelBuilder.Entity<Purchases>()
            .HasOne(p => p.Users)
            .WithMany(p => p.PurchasesList)
            .HasForeignKey(p => p.UserId);

        modelBuilder.Entity<Reviews>()
            .HasKey(r => new { r.MovieId, r.UserId });
        modelBuilder.Entity<Reviews>()
            .HasOne(r => r.Movies)
            .WithMany(r => r.ReviewsList)
            .HasForeignKey(r => r.MovieId);
        modelBuilder.Entity<Reviews>()
            .HasOne(r => r.Users)
            .WithMany(r => r.ReviewsList)
            .HasForeignKey(r => r.UserId);
        modelBuilder.Entity<UserRoles>()
            .HasKey(ur => new { ur.UserId, ur.RoleId });
        modelBuilder.Entity<UserRoles>()
            .HasOne(ur => ur.Users)
            .WithMany(u => u.UserRolesList)
            .HasForeignKey(ur => ur.UserId);

        modelBuilder.Entity<UserRoles>()
            .HasOne(ur => ur.Roles)
            .WithMany(r => r.UsersList)
            .HasForeignKey(ur => ur.RoleId);

        modelBuilder.Entity<Trailers>()
            .HasOne(t => t.Movies)
            .WithMany(m => m.TrailersList)
            .HasForeignKey(t => t.MovieId);
    }
}