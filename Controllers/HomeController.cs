using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;

namespace CarDealer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/addcar")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/results")]
    public ActionResult Results()
    {
      return View();
    }

  }
}
