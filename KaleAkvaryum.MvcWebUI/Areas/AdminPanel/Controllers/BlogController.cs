using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.Model.Entity;
using KaleAkvaryum.MvcWebUi.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KaleAkvaryum.MvcWebUi.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class BlogController : Controller
    {
        private readonly IBlogBs _blogbs;

        public BlogController(IBlogBs blogBs)
        {
            _blogbs = blogBs;
        }

        public IActionResult Index()
        {
            List<Blog> blogs = _blogbs.GetAll();
            return View(blogs);
        }
        [HttpPost]
        public IActionResult Index(int blogId)
        {

            var entity = _blogbs.GetByBlogId(blogId);
            if (entity != null)
            {
                _blogbs.Delete(entity);
            }
            return RedirectToAction("index");

        }


        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Blog vm)
        {
            _blogbs.Insert(vm);
            return Json(new { isOk = true, Message = "Etkinlik Başarıyla Kaydedildi" });

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
                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blogphotos", randomFileName);
                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[0].CopyTo(stream);
                }
                return Json(new { isOk = true, PhotoPath = "/images/blogphotos/" + randomFileName });




            }
            else
            {
                return Json(new { isOk = false, Message = "Lütfen Bir Adet Fotoğraf Seçiniz..." });
            }


        }
    }
}
