using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.Model.Entity;
using KaleAkvaryum.Model.Model;
using KaleAkvaryum.MvcWebUi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KaleAkvaryum.MvcWebUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFishBs _fishbs;
        private readonly IBlogBs _blogbs;


        public HomeController(IFishBs fishBs, IBlogBs blogBs)
        {
            _fishbs = fishBs;
            _blogbs = blogBs;


        }

        public IActionResult Index()
        {
            List<Fish> fishes = _fishbs.GetAll();
            
            return View(fishes);
        }
        

    }
}
