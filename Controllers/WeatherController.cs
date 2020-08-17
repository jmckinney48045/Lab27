using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab27API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab27API.Controllers
{

    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _weatherService.GetAllRoots();
            return View(model);
        }
    }
}