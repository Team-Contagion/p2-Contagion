using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contagion.API.Models;

namespace Contagion.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ContagionController : Controller
  {
    [HttpPost]
    public IActionResult NewUser()
    {
      return View();
    }
  }
}
