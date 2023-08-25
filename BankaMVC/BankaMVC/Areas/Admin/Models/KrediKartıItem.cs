namespace BankaMVC.Areas.Admin.Models

{
    public class KrediKartıItem
    {
        public int KrediKartıID { get; set; }
        public int MusteriID { get; set; }
        public string? Baglıİban { get; set; }
        public string? KartNo { get; set; }
        public int? KartkullanımAy { get; set; }
        public int? KartkullanımYıl { get; set; }
        public int? KartCVCNo { get; set; }
        public string? KartSahipAd { get; set; }
        public string? KartSahipSoyad { get; set; }
        public string? KartTeknolojisi { get; set; }
    }
}
