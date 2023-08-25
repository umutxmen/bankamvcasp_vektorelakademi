namespace BankaMVC.Areas.Admin.Models.Dtos.BankaKartiDtos
{
    public class NewBankaKartiDto
    {
        public int MusteriID { get; set; }
        public string? Baglıİban { get; set; }
        public string? KartNo { get; set; }
        public int? KartSonKullanımAy { get; set; }
        public int? KartSonKullanımYıl { get; set; }
        public string? KartSahipAd { get; set; }
        public string? KartSahipSoyad { get; set; }
        public string? KartTeknolojisi { get; set; }
    }
}
