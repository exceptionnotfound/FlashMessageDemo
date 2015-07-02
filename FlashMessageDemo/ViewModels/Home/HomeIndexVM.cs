using FlashMessageDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlashMessageDemo.ViewModels.Home
{
    public class HomeIndexVM
    {
        [Display(Name = "Type a message: ")]
        public string Message { get; set; }

        [Display(Name = "Type: ")]
        public FlashMessageType Type { get; set; }
    }
}