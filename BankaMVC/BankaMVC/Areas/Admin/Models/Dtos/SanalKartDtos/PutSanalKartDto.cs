namespace BankaMVC.Areas.Admin.Models.Dtos.SanalKartPutDto

{
    public class PutSanalKartDto
    {
        public int SanalKartID { get; set; }
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
