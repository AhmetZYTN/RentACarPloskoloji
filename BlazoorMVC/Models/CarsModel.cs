using System.Text.Json.Serialization;

namespace BlazoorMVC.Models
{
    public class CarsModel
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public int CarRentalFee { get; set; }
        public int CarProductionId { get; set; }
        public int NumberPlatesStart { get; set; }
        public string CarsPicture { get; set; }
        public string NumberPlateMiddle { get; set; }
        public int NumberPlateEnd { get; set; }
        //public DateTime RentDate { get; set; }
        public DateTime RentDate { get; set; }
        public bool RentACarSell { get; set; }
        public string Thumbnail { get; set; }
        public string About { get; set; }
        public string Adress { get; set; }
    }

    public class UrunCesidi 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
    }
}
