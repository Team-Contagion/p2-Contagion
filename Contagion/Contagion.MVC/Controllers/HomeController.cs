using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contagion.MVC.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Contagion.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _http = new HttpClient();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var res = _http.GetAsync("https://api.ipgeolocation.io/ipgeo?apiKey=600432fc747440a59322059f20b98219").GetAwaiter().GetResult();
            var loc = JsonConvert.DeserializeObject<LocationModel>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            var dlat = decimal.Parse(loc.latitude);
            var dlng = decimal.Parse(loc.longitude);
            var user = new UserModel(999999999, dlat, dlng);

            string json = JsonConvert.SerializeObject(user);
            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = _http.PostAsync("http://api/contagion", httpContent).GetAwaiter().GetResult();

            response.EnsureSuccessStatusCode();

            var res2 = _http.GetAsync("http://api/contagion").GetAwaiter().GetResult();
            var users = JsonConvert.DeserializeObject<List<UserModel>>(res2.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            
            return View(users);
        }

        [HttpGet]
        public IActionResult Users()
        {
            return View(new UserModel());
        }

        public IActionResult GetLocation()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
