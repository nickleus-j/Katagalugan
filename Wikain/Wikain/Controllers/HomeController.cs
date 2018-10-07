using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Wikain.Models;
using Wikain.Service;

namespace Wikain.Controllers
{
    public class HomeController : Controller
    {
        [EnableCors("AllowAllOrigins")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Reactor()
        {
            return View();
        }
        public IActionResult RandomWord()
        {
            try { return Content(WordProvider.GetWord()); }
            catch { return Content(@"Resource/Tagalog.txt"); }
        }
    }
}
