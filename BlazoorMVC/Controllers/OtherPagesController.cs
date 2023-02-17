using Microsoft.AspNetCore.Mvc;

namespace BlazoorMVC.Controllers
{
    public class OtherPagesController : Controller
    {
        public IActionResult Faq()
        {
            return View();
        }

        public IActionResult FullWidth()
        {
            return View();
        }

        public IActionResult SideBar()
        {
            return View();
        }

        public IActionResult HTTPError()
        {
            return View();
        }
    }
}
