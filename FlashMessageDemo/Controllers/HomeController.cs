using FlashMessageDemo.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlashMessageDemo.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Index(string id)
        {
            HomeIndexVM model = new HomeIndexVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HomeIndexVM model)
        {
            SetFlash(model.Type, model.Message);
            return RedirectToAction("Index", new {id = "test.layout"});
        }
    }
}