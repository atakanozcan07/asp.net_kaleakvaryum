using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.Model.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaleAkvaryum.MvcWebUi.Controllers
{
    public class BlogController : Controller
    {
        
        private readonly IBlogBs _blogbs;


        public BlogController(IBlogBs blogBs)
        {
            
            _blogbs = blogBs;

        }
        public IActionResult Index()
        {
            List<Blog> blogs =_blogbs.GetAll();
            return View(blogs);
        }
        public IActionResult Detail(int id) {
            
            return View(_blogbs.GetByBlogId(id));
        
        }
    }
}
