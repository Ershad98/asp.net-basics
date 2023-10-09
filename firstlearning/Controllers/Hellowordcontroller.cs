using Microsoft.AspNetCore.Mvc;
using firstlearning.Models;
namespace firstlearning.Controllers
{
    public class Hellowordcontroller : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
           // DogViewModel doggo = new DogViewModel() { Name = "sif",Age =   2};
            return View(dogs);
        }
        public IActionResult create ()
        {
            var dogvm = new DogViewModel();
            return View(dogvm);
        }
        public IActionResult createDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
