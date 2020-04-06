using Contagion.Storage.Models;
using System.Collections.Generic;
using Contagion.Storage.Repositories;

namespace Contagion.MVC.Models
{
  public class UserModel
  {
    private readonly UserRepo _up = new UserRepo();

    public long UserPhone { get; set; }
    public decimal Lat { get; set; }
    public decimal Lon { get; set; }
    public List<User> users { get; set; }
    
    public UserModel()
    {
      users = _up.Get();
    }

    public UserModel(long up, decimal lat, decimal lg)
    {
      UserPhone = up;
      Lat = lat;
      Lon = lg;
    }
  }

  
}