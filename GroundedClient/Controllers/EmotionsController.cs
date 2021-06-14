using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroundedClient.Models;

namespace GroundedClient.Controllers
{
  public class EmotionsController : Controller
  {
    public IActionResult Index()
    {
      var allEmotions = Emotion.GetEmotions();
      return View(allEmotions);
    }

    public IActionResult Details(int id)
    {
      var emotion = emotion.GetDetails(id);
      return View(emotion);
    }

  }
}