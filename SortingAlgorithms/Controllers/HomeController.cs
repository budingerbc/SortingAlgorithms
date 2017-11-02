using Microsoft.AspNetCore.Mvc;
using SortingAlgorithms.Models;
using System.Collections.Generic;
using System;

namespace SortingAlgorithms.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      ArrayData sort = new ArrayData();
      Console.WriteLine(sort);
      return View();
    }
  }
}
