using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GroundedClient.Models;

namespace GroundedClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
        var allResources = Resource.GetResources();
        return View(allResources);
        }

        // public IActionResult Index()
        // {
        //     return View();//we will need to reference the resources here to get access to the names.
        // }

        // public IActionResult Index()
        // {
        //     Dictionary<string, object> model = new Dictionary<string, object>();
        //     List<Resource> resourceList = _logger.Resources.ToList();
        //     model.Add("Resources", resourceList);
        //     return View(model);
        // }

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
