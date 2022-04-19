using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CKEditor.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Editor()
        {
            return View();
        }
    }
}
