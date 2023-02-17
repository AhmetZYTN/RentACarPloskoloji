namespace BlazoorMVC.Models
{
    public class KategoridekiUrunlerModel : CarsModel
    {
        public List<UrunCesidi> Urunsa { get; set; }
        public List<CarsModel> Carssa { get; set; }
        public int UrunSayisi { get; set; }
    }
}
