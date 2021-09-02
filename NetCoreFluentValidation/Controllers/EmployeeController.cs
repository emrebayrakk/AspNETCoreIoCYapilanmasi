using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreFluentValidation.Models;

namespace NetCoreFluentValidation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreatedEmployee()
        {
            return View();
        }

        public IActionResult CreatedEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            return View();
        }



    }
}
