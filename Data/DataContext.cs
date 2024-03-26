using Microsoft.EntityFrameworkCore;
using WinterDemo.Entity;
namespace WinterDemo.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Game> Games { get;set; }
}