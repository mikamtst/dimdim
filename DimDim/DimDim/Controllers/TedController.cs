using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DimDim.Controllers
{
    public class TedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
