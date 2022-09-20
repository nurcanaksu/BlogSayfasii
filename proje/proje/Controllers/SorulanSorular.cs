using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje.Controllers
{
    public class SorulanSorular : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
