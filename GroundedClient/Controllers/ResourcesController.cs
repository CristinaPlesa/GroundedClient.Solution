using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroundedClient.Models;

namespace GroundedClient.Controllers
{
  public class ResourcesController : Controller
  {
    public IActionResult Index()
    {
      var allResources = Resource.GetResources();
      return View(allResources);
    }

    [HttpPost]
    public IActionResult Index(Resource resource)
    {
      Resource.Post(resource);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var resource = Resource.GetDetails(id);
      return View(resource);
    }

  }
}