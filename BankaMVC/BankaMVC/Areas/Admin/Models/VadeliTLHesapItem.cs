namespace BankaMVC.Areas.Admin.Models

{
    public class VadeliTLHesapItem
    {
        public int VadeliTLHesapID { get; set; }
        public int MusteriID { get; set; }
        public decimal Varlık { get; set; }
        public DateTime? VadeBasTarihi { get; set; }
        public DateTime? VadeBitisTarihi { get; set; }
        public int? VadeliFaizoran { get; set; }
        public decimal? VadeSonuMiktar { get; set; }
    }
}
