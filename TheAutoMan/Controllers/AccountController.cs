﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheAutoMan.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult LoginIndex()
        {
            return View();
        }
    }
}
