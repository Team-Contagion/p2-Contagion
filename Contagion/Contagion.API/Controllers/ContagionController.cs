using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contagion.API.Models;
using Contagion.Storage.Repositories;
using Contagion.Storage.Models;

namespace Contagion.API.Controllers
{

  [ApiController]
  [Route("[controller]")]
  public class ContagionController : ControllerBase
  {
    private readonly UserRepo _up = new UserRepo();

    [HttpPost]
    public bool NewUser(User user)
    {
      return true;
    }
  }
}
