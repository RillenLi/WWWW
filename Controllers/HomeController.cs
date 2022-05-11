using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WWWW.Models;
using Data.Repositories;
using Data.IRepositories;

namespace WWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository repository = new Repository();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult GetRegion(int i)
        {
            return PartialView("_Region", repository.GetRegion(i));
        }
        [HttpPost]       

        public IActionResult GetTable()
        {
            return PartialView("_Table", repository.GetUsers());
                /*new List<UserModel>
            {
                new UserModel
                {
                    Id=1,
                    Name="SSS"
                },
                new UserModel
                {
                    Id=2,
                    Name="aaaa"
                }
            }); */
        }

        public IActionResult Privacy()
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
