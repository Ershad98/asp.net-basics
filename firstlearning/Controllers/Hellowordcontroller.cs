using Microsoft.AspNetCore.Mvc;
using firstlearning.Models;
namespace firstlearning.Controllers
{
    public class Hellowordcontroller : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name = "sif",Age =12};
            return View(doggo);
        }
        public IActionResult test ()
        {
            return View();
        }
    }
}
