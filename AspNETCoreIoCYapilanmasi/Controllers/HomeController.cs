using AspNETCoreIoCYapilanmasi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNETCoreIoCYapilanmasi.Services;
using AspNETCoreIoCYapilanmasi.Services.Interface;

namespace AspNETCoreIoCYapilanmasi.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILog _log;
        //public HomeController(ILog log)
        //{
        //    _log = log;
        //}

        public IActionResult Index()
        {
            //new operatörü ile ilgili serviceslerden nesne üretiliyorsa bağımlılık yaratılmış olur ve değişiklik olduğu takdirde kaynak kodda tekrar değişikliğe gidilmesi gerekilir.

           //_log.Log();
            return View();
        }

        public IActionResult Privacy([FromServices]ILog log) //action bazında nesne talebi FromServices Attribute’u kullanılır.
        {
            log.Log();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
