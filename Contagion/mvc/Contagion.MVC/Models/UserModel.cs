using System.Collections.Generic;

namespace Contagion.MVC.Models
{
  public class UserModel
  {
    public long UserPhone { get; set; }
    public decimal Lat { get; set; }
    public decimal Lon { get; set; }
    public string HealthStatus { get; set; }

    public UserModel(long up, decimal lat, decimal lg, string healthStatus)
    {
      UserPhone = up;
      Lat = lat;
      Lon = lg;
      HealthStatus = healthStatus;
    }

    public UserModel() {}
  }  
}