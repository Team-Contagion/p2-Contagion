using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Contagion.Storage.Models;

namespace Contagion.Storage.Database
{
  public class ContagionDbContext : DbContext
  {
    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=sql;database=contagiondb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<User>().HasKey(u => u.UserId);
      builder.Entity<User>().Property(u => u.UserId).ValueGeneratedNever();
      
      builder.Entity<User>().HasData(new User[]
      {
        new User() { UserPhone = 0987653432, Lat = 32.7286784M, Lon = -97.1046912M},
        new User() { UserPhone = 8175550150, Lat = 32.7286784M, Lon = -97.1346912M},
        new User() { UserPhone = 8175550131, Lat = 32.7566784M, Lon = -97.1146912M},
        new User() { UserPhone = 8175550117, Lat = 32.7066784M, Lon = -97.0846912M},
        new User() { UserPhone = 8175550142, Lat = 32.7186784M, Lon = -97.2986532M},
        new User() { UserPhone = 8175550101, Lat = 32.7413513M, Lon = -97.0846912M},
        new User() { UserPhone = 8175550148, Lat = 32.7281164M, Lon = -97.1212765M},
        new User() { UserPhone = 8175550189, Lat = 32.7185123M, Lon = -97.1416348M},       
      });
    }
    private static readonly ContagionDbContext _db = new ContagionDbContext();
    public ContagionDbContext Instance { get { return _db; } }
  }
}
// add migration
//dotnet ef migrations add firstmigration -p Contagion.Storage/Contagion.Storage.csproj -s Contagion.MVC/Contagion.MVC.csproj
// start up container
//docker container run -dit --rm --name sqlserver -p 1433:1433 -e 'ACCEPT_EULA=y' -e 'SA_PASSWORD=Password12345' mcr.microsoft.com/mssql/server:2017-latest
// update database
//dotnet ef database update -p Contagion.Storage/Contagion.Storage.csproj  -s Contagion.MVC/Contagion.MVC.csproj

        //   new UserModel() { UserPhone = 8175550150, Lat = 32.7286784M, Long = -97.1346912M},
        //   new UserModel() { UserPhone = 8175550131, Lat = 32.7566784M, Long = -97.1146912M},      
        //   new UserModel() { UserPhone = 8175550117, Lat = 32.7066784M, Long = -97.0846912M},
        //   new UserModel() { UserPhone = 8175550142, Lat = 32.7186784M, Long = -97M},
        //   new UserModel() { UserPhone = 8175550101, Lat = 32.74M, Long = -97.0846912M},
        //   new UserModel() { UserPhone = 8175550148, Lat = 32.728M, Long = -97.12M},
        //   new UserModel() { UserPhone = 8175550148, Lat = 32.718M, Long = -97.14M}          