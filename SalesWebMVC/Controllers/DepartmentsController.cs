﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Eletrônicos" });
            departments.Add(new Department { Id = 2, Name = "Eletrodomésticos" });

            return View(departments);
        }
    }
}
