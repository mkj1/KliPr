﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KliPr.Controllers
{
    public class ForskerController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}