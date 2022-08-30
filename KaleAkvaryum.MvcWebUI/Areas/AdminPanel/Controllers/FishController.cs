using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.Model.Model;
using KaleAkvaryum.MvcWebUi.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KaleAkvaryum.MvcWebUi.Areas.AdminPanel.Controllers
{
    
    [Area("AdminPanel")]
    public class FishController : Controller
    {
        private readonly IFishBs _fishbs;
        private readonly ITbalikBs _tbalikbs;

        public FishController(IFishBs fishBs,ITbalikBs tbalikBs)
        {
            _fishbs = fishBs;
            _tbalikbs = tbalikBs;


        }
        public IActionResult Index()
        {
            List<Fish> fishes = _fishbs.GetAll();
            return View(fishes);
        }

        [HttpPost]
        public IActionResult Index(int fishId)
        {

            var entity = _fishbs.GetById(fishId);
            if (entity != null)
            {
                _fishbs.Delete(entity);
            }
            return RedirectToAction("index");

        }
        public IActionResult New()
        {
            

            
            List<SelectListItem> tbalikid = _tbalikbs.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
            tbalikid.Insert(0, new SelectListItem() { Text = "Balık Çeşidi Seçiniz...", Value = "-1" });

            return View(tbalikid);
        }
        [HttpPost]
        public IActionResult New(Fish vm)
        {
            _fishbs.Insert(vm);

            return Json(new { isOk = true, message = "Başarıyla Kaydedildi" });
        }
        [HttpPost]
        public IActionResult PhotoUpload()
        {
            IFormFileCollection files = Request.Form.Files;
            if (files.Count > 0)
            {
                var fileName = files[0].FileName;
                Console.WriteLine(fileName);
                var contentType = files[0].ContentType;
                if (!contentType.StartsWith("image/"))
                    return Json(new { isOk = false, Message = "Lütfen Bir Resim Dosyası Seçiniz" });
                var randomFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(fileName));
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/fishphotos", randomFileName);
                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(stream);
                }
                return Json(new { isOk = true, PhotoPath = "/images/fishphotos/" + randomFileName });




            }
            else
            {
                return Json(new { isOk = false, Message = "Lütfen Bir Adet Fotoğraf Seçiniz..." });
            }

        }

    }
}










