﻿using Microsoft.AspNetCore.Mvc;

namespace UserManagementDemo.Web.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
