using Microsoft.AspNetCore.Mvc;
using zadanie.Models;

namespace zadanie.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Data data)
        {
            if (ModelState.IsValid)
            {
                data.SuccessMessage = "Rejestracja zakończona pomyślnie";
                return View("Complete", data);
            }
            return View();
        }

        public IActionResult Complete(Data data)
        {
            return View(data);
        }
    }
}
