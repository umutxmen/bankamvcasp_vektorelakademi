namespace BankaMVC.Areas.Admin.Models.Dtos.SanalKartDtos

{
    public class NewSanalKartDto
    {
        public int MusteriID { get; set; }
        public int? BagliKrediKartID { get; set; }
        public string? KartNo { get; set; }
        public int? KartKullanımAy { get; set; }
        public int? KartKullanumYıl { get; set; }
        public int? KartCVCNo { get; set; }
        public string? KartSahipAd { get; set; }
        public string? KartSahipSoyad { get; set; }
        public string? KartTeknolojisi { get; set; }

    }
}
