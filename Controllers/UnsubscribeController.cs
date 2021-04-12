using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestMVC.Business;
using TestMVC.Models;

//https://localhost:5001/Unsubscribe/process?ucid=d112

namespace TestMVC.Controllers
{
    public class UnsubscribeController : Controller
    {
        private readonly ILogger<UnsubscribeController> _logger;
        private Service _service = new Service();

        public UnsubscribeController(ILogger<UnsubscribeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Process(string ucid)
        {
            var result = _service.Process(ucid);
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
