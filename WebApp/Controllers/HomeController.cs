﻿using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = new HttpClient();
        }

        public async Task<IActionResult> Index()
        {
            //Get IP Address of API Host
            string url = "http://" + _configuration["ApiHost"] + "/api/Hostname";
            
            ViewData["HostName"] = await _client.GetStringAsync(url);

            return View();
        }
    }
}