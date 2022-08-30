using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.Model.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaleAkvaryum.MvcWebUi.Controllers
{
    public class ProductController : Controller
    {
        private readonly IFishBs _fishbs;
        private readonly ITbalikBs _tbalikbs;



        public ProductController(IFishBs fishBs,ITbalikBs tbalikBs)
        {
            _fishbs = fishBs;
            _tbalikbs = tbalikBs;
            


        }
        public IActionResult Index(int id)
        {
            List<Fish> fishes;
            if (id > 0) {
                fishes = _fishbs.GetAll(x => x.TbalikId == id);
            }
            else
            {
                fishes = _fishbs.GetAll();
            }
            
            return View(fishes);
        }
        public IActionResult Detail(int id)
        {
            
            return View(_fishbs.GetById(id));
        }
        public IActionResult List(string tbalik)
        {
            return View();

        }
    }
}
