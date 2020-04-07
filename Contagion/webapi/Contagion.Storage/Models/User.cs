using System;

namespace Contagion.Storage.Models
{
  public class User
  {
    public long UserId { get; set; }
    public long UserPhone { get; set; }
    public decimal Lat { get; set; }
    public decimal Lon { get; set; }

    public User()
    {
      UserId = DateTime.Now.Ticks;
    }

  }
}
