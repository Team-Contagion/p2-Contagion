using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contagion.Storage.Repositories;
using Contagion.Storage.Models;

namespace Contagion.API.Controllers
{

  [ApiController]
  [Route("[controller]")]
  public class ContagionController : ControllerBase
  {
    private static readonly UserRepo _ur = new UserRepo();

    private readonly ILogger<ContagionController> _logger;

    public ContagionController(ILogger<ContagionController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
      List<User> _lu = _ur.Get();
      return Ok(_lu);
    }

    [HttpPost]
    public IActionResult GetPost([FromBody] User user)
    {
      _ur.Post(user);
      return Ok();
    }
  }
}
