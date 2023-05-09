// Purpose: Contains the DataContext class which is used to connect to the database.
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Activity> Activities { get; set; }
  }
}