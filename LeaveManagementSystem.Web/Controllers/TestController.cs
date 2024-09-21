﻿using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Valentin",
                DateOfBirth = new DateTime(2003,01,08)
            };  
            return View(data);
        }
    }
}
