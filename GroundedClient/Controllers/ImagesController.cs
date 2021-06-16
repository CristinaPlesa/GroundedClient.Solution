// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using GroundedClient.Models;
// using MvcApplication8.Models;

// public class ImgsController : Controller
// {
//   List<img> imgs = new List<img>
//   {
//     new img { ResourceName = "Anxious", AltDescription="Pacific City", ImageUrl="~/img/Anxiety.jpg"},
//     new img { ResourceName = "Guilty", AltDescription="Feather in air over leg", ImageUrl="~/img/Guilt.jpg"},
//     new img { ResourceName = "Depressed", AltDescription="Close up of leaves", ImageUrl="~/img/Depression.jpg"},
//     new img { ResourceName = "Restless", AltDescription="Forest", ImageUrl="~/img/Restless.jpg"},
//     new img { ResourceName = "Fearful", AltDescription="Snowy Mountains", ImageUrl="~/img/Fear.jpg"},
//     new img { ResourceName = "Angry", AltDescription="Mountains at Dusk", ImageUrl="~/img/Anger.jpg"},
//     new img { ResourceName = "Stressed", AltDescription="Night Sky", ImageUrl="~/img/Stress.jpg"},
//     new img { ResourceName = "Sad", AltDescription="Field with Sunset", ImageUrl="~/img/Sad.jpg"},
//     new img { ResourceName = "Nervous", AltDescription="Sapling Plants", ImageUrl="~/img/Nervous.jpg"},
//     new img { ResourceName = "Insecure", AltDescription="Sunset over Mountains", ImageUrl="/img/Insecure.jpg"},
//     new img { ResourceName = "Home", AltDescription="Home Image", ImageUrl="/img/Home.jpg"}
//   };

//   public ActionResult Index()
//   {
//     return View(Product);
//   }
//   public ActionResult Details(int id)
//   {
//     var result = Image.Find(item => item.ImageId == id);
//     return View(result);
//   }
// }





