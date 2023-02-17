using Microsoft.AspNetCore.Mvc;

namespace BlazoorMVC.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult OneColumn()
        {
            return View();
        }
        public IActionResult TwoColumn()
        {
            return View();
        }
        public IActionResult ThreeColumn()
        {
            return View();
        }
        public IActionResult SingleColumn()
        {
            return View();
        }
    }
}
