using BlazoorMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace BlazoorMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult KategoriMenu() 
        {
            List<UrunCesidi> urunCesids = new List<UrunCesidi>()
            {
                new UrunCesidi() {
                    Id=12,
                    Name = "C Sınıfı",
                    Description="Orta Segment"
                },
                new UrunCesidi()
                {
                    Id=22,
                    Name="Süper Sport",
                    Description="Racing"
                },
                new UrunCesidi()
                {
                    Id=32,
                    Name="J Segmenti",
                    Description="SUV ,CUV"
                }
            };
            return PartialView(KategoriMenu);
        }
    }
}
