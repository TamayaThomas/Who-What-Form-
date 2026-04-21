using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel.DataAnnotations;
using Who_What_Form_.Pages.models;
namespace Who_What_Form_.Pages.models;

public class AppDbContext : AppDbContext
{
    public DbSet<Film> Films {get; set;}
    public DbSet<Review> Reviews {get; set;}

    public DbSet<Account> Accounts {get; set;}

    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }
}