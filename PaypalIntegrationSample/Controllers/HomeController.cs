using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace PaypalIntegrationSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            ViewBag.PayPalClientId = _config.GetValue<string>("ApplicationSettings:PayPalClientId");
            return View();
        }

        public IActionResult Privacy() => View();

        public IActionResult Error() => View();
    }
}
