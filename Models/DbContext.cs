using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Who_What_Form_.Models;

public class AppDbContext : DbContext
{
    public DbSet<Film> Films {get; set;}
    public DbSet<Review> Reviews {get; set;}

    public DbSet<Account> Accounts {get; set;}

    public DbSet<Actor> Actors {get; set;}
    public DbSet<Source> Sources {get; set;}
    public DbSet<Music> Musics {get; set;}

    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }
}