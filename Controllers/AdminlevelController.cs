﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberTravels.Controllers
{
    public class AdminlevelController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
