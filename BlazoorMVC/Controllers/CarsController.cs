using BlazoorMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;

namespace BlazoorMVC.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult CarsTest()
        {
            List<CarsModel> carsModels = new List<CarsModel>() {
            new CarsModel(){
            RentACarSell=true,
            Id = 1,
            CarName= "Maserati Ghibli",
            CarsPicture= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8zzHtDnoUgX5R-Gd0Z-GvrvX3XrYCC4ixSw&usqp=CAU",
            CarRentalFee=20000,
            CarProductionId=1234560,
            NumberPlatesStart=31,
            NumberPlateMiddle= "AZ",
            NumberPlateEnd= 31,
            RentDate= new DateTime(2022,05,31)

            },


            new CarsModel()
            {
                RentACarSell=true,
                Id = 2,
                CarName = "Aston Martin",
                CarsPicture= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTzwI3F-oKgQOSKoKnrOnK7xgbcPgAd9S-0Eg&usqp=CAU",
                CarRentalFee=30000,
                CarProductionId = 1234561,
                NumberPlatesStart = 31,
                NumberPlateMiddle = "AZP",
                NumberPlateEnd = 35,
                RentDate = new DateTime(2022, 12, 27)

            },
            new CarsModel()
            {
                RentACarSell=true,
                Id = 3,
                CarName = "Jaguar",
                CarsPicture= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTkfK4EZJr1ffoGrC6Jt42pgrncxk-PrliVVA&usqp=CAU",
                CarRentalFee=40000,
                CarProductionId = 1234560,
                NumberPlatesStart = 35,
                NumberPlateMiddle = "AZF",
                NumberPlateEnd = 31,
                RentDate = new DateTime(2022, 11, 11)
            },
            new CarsModel()
            {
                RentACarSell=true,
                Id = 4,
                CarName = "McLaren",
                CarsPicture= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_TLIXCa2-hz0R9e6x51SsAzLk12CbU9CqZw&usqp=CAU",
                CarRentalFee=50000,
                CarProductionId = 1234560,
                NumberPlatesStart = 34,
                NumberPlateMiddle = "AZT",
                NumberPlateEnd = 311,
                RentDate = new DateTime(2022, 01, 22)
            }
            };


            KategoridekiUrunlerModel model = new KategoridekiUrunlerModel();
            model.UrunSayisi = carsModels.Count ;
            model.Carssa = carsModels;
            


            //ViewBag.UrunCesitleri = urunCesidis;
            //ViewBag.NumberOfCars = carsModels.Count();
            return View(model);
        }
    }
}

