using KaleAkvaryum.Business.Abstract;
using KaleAkvaryum.Model.Entity;
using KaleAkvaryum.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaleAkvaryum.MvcWebUi.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ManagerController : Controller
    {
        private readonly IManagerBs _managerbs;
        public ManagerController(IManagerBs managerBs)
        {
            _managerbs = managerBs;

        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(ManagerLoginVm vm)
        {
            Manager manager = _managerbs.LogIn(vm.UserName, vm.Password);
            if (manager != null)
                return Json(new { isOk = true });

            return Json(new { isOk = false, Message = "Kullanıcı Bulunamadı" });
        }
    }
}
