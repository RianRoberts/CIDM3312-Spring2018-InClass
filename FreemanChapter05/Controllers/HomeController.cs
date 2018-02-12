using Microsoft.AspNetCore.Mvc;
using FreemanChapter05.Models;

namespace Razor.Controllers {
    public class HomeController : Controller {

    /*
    Product[] array = {
        new Product {Name = "Kayak", Price = 275M},
        new Product {Name = "Lifejacket", Price = 48.95M},
        new Product {Name = "Soccer ball", Price = 19.50M},
        new Product {Name = "Corner flag", Price = 34.95M}
    };
    return View(array);*/        

        public IActionResult Index() {

            return View();
        }

        public IActionResult MakeNewTodo(string todo)
        {
            Repository.ToDos.Add(todo);
            return View("MakeNewTodo", todo);
        }
    }
}