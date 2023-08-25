namespace BankaMVC.Areas.Admin.Models.Dtos.HarcamaDtos

{
    public class PutHarcamaDto
    {
        public int HarcamaID { get; set; }
        public int MusteriID { get; set; }
        public int HarcananKartID { get; set; }

        public decimal? HarcananMiktar { get; set; }
        public int? TaksitMiktarı { get; set; }
        public DateTime? HarcamaTarihi { get; set; }
        public string? SatıcıKodu { get; set; }
    }
}
