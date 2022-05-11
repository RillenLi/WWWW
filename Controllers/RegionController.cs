using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWWW.Models;
using Data.Repositories;
using Data.IRepositories;

namespace WWWW.Controllers
{
    public class RegionController : Controller
    {
        private readonly IRepository _repository;
        public RegionController()
        {
            _repository = new Repository();
        }
        
        [HttpPost]
        public IActionResult GetRegion(int i)
        {

            return PartialView("_Region", _repository.GetRegion(i));
        }
    }
}
