using Microsoft.AspNetCore.Mvc;

namespace BookBarn2.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[Route("Book/Info")]

        public IActionResult about()
        {
            return View();
        }
    }
}
