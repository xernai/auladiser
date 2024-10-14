using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NikiShop.ToDo.MvcClient.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NikiShop.ToDo.MvcClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ToDo()
        {
            // TODO: usar la clase HttpClient de .NET para conectarse a la API
            // var baseURL = "http://localhost:44323/"
            // var baseURL = baseURL + "WeatherForecast/GetAllToDoList"
            // var httpClient = new HttpClient();

            // httpClient deserializarlo a un Modelo = todoList

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
