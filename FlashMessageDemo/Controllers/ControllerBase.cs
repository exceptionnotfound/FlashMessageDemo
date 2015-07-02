using FlashMessageDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlashMessageDemo.Controllers
{
    public class ControllerBase : Controller
    {
        public void SetFlash(FlashMessageType type, string text)
        {
            TempData["FlashMessage.Type"] = type;
            TempData["FlashMessage.Text"] = text;
        }
    }
}