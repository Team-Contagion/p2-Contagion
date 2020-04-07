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
using System.Net;
using System.Net.Sockets;
using System.Web;
using Microsoft.AspNetCore.Http;

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

        public string GetIPAddress()
        {
            string IPA = "";
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList) {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
                    IPA = Convert.ToString(IP);
                }
            }
            return IPA;
        }

        // private string GetUserIP()
        //     {
        //         HttpContext context = HttpContext.Current; 
        //         string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        //     }

        public IActionResult Index()
        {
            //var host = Dns.GetHostEntry(Dns.GetHostName());
            //var res = _http.GetAsync("https://api.ipgeolocation.io/ipgeo?apiKey=600432fc747440a59322059f20b98219").GetAwaiter().GetResult();
            
            // var res = _http.GetAsync("http://ip-api.com/json/64.189.196.112").GetAwaiter().GetResult();
            //var res = _http.GetAsync(String.Concat("http://ip-api.com/json/",GetIPAddress())).GetAwaiter().GetResult();
            // var loc = JsonConvert.DeserializeObject<LocationModel>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            // var dlat = decimal.Parse(loc.lat);
            // var dlng = decimal.Parse(loc.lon);
            // var user = new UserModel(999999999, dlat, dlng);

            // string json = JsonConvert.SerializeObject(user);
            // HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            // var response = _http.PostAsync("http://api/contagion", httpContent).GetAwaiter().GetResult();

            // response.EnsureSuccessStatusCode();

            // var res2 = _http.GetAsync("http://api/contagion").GetAwaiter().GetResult();
            // var users = JsonConvert.DeserializeObject<List<UserModel>>(res2.Content.ReadAsStringAsync().GetAwaiter().GetResult());
            
            return View(new UserModel());
        }

        [HttpPost]
        public IActionResult Users(UserModel userModel)
        {
          Console.WriteLine(userModel.Lat);
          Console.WriteLine(userModel.Lon);
          Console.WriteLine(userModel.UserPhone);
          Console.WriteLine(userModel.HealthStatus);
          string json = JsonConvert.SerializeObject(userModel);
          HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
          var response = _http.PostAsync("http://api/contagion", httpContent).GetAwaiter().GetResult();

          response.EnsureSuccessStatusCode();

          var res = _http.GetAsync("http://api/contagion").GetAwaiter().GetResult();
          var users = JsonConvert.DeserializeObject<List<UserModel>>(res.Content.ReadAsStringAsync().GetAwaiter().GetResult());
          return View("Map", users);
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
