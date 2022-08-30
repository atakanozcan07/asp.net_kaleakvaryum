using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.Model.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaleAkvaryum.MvcWebUi.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class TbalikController : Controller
    {
        private readonly ITbalikBs _tbalikbs;

        public TbalikController(ITbalikBs tbalikBs)
        {
            _tbalikbs = tbalikBs;


        }
        public IActionResult Index()
        {
            List<Tbalik> tbaliks = _tbalikbs.GetAll();
            return View(tbaliks);
        }
        [HttpPost]
        public IActionResult Index(int typeId)
        {

            var entity = _tbalikbs.GetById(typeId);
            if (entity != null)
            {
                _tbalikbs.Delete(entity);
            }
            return RedirectToAction("index");

        }
        public IActionResult New()
        {

            return View();
        }
        [HttpPost]
        public IActionResult New(Tbalik vm)
        {
            _tbalikbs.Insert(vm);

            return Json(new { isOk = true, message = "Başarıyla Kaydedildi" });
        }

    }
}
